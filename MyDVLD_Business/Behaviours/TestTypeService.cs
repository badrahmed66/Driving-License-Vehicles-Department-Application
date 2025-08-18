using System;
using MyDVLD_DTO;
using System.Collections.Generic;
using MyDVLD_DAL;
using MyDVLD_BLL.Validation;

namespace MyDVLD_BLL
{
	/// <summary>
	/// Service class for managing Test Types.
	/// Handles retrieval, insertion, updating, and deletion of test types.
	/// </summary>
	public class TestTypeService
	{
		/// <summary>
		/// The current test type information.
		/// </summary>
		private TestTypeDTO TestTypeInfo { get; set; }

		/// <summary>
		/// Initializes a new instance of <see cref="TestTypeService"/> with the specified TestTypeDTO.
		/// </summary>
		/// <param name="testDTO">The test type DTO.</param>
		public TestTypeService(TestTypeDTO testDTO)
		{
			TestTypeInfo = testDTO ?? throw new ArgumentNullException(nameof(testDTO));
		}

		/// <summary>
		/// Retrieves all test types.
		/// </summary>
		/// <returns>A list of <see cref="TestTypeDTO"/>.</returns>
		static public List<TestTypeDTO> RetrieveAllTests()
		{
			return TestTypeDAL.Retrieve();
		}

		/// <summary>
		/// Finds a test type by its ID.
		/// </summary>
		/// <param name="id">The test type ID.</param>
		/// <returns>The <see cref="TestTypeDTO"/> if found; otherwise, null.</returns>
		public static TestTypeDTO FindTestByID(int id)
		{
			if (id <= 0) return null;
			return TestTypeDAL.FindByID(id) ?? null;
		}

		/// <summary>
		/// Inserts the current test type into the database.
		/// </summary>
		/// <param name="message">Returns a message describing the result.</param>
		/// <returns>True if insertion is successful; otherwise, false.</returns>
		public bool InsertTest(out string message)
		{
			message = "";

			if (TestTypeInfo == null)
			{
				message = "Invalid Test Type";
				return false;
			}

			if (TestTypeValidator.IsExists(TestTypeInfo.Title))
			{
				message = "The Title For This Test Is Already Exists";
				return false;
			}

			int id = TestTypeDAL.Insert(TestTypeInfo);

			if (id > 0)
			{
				message = "Test Type Added Successfuly";
				TestTypeInfo.ID = id;
				return true;
			}
			else
			{
				message = "Test Type Could not add";
				return false;
			}
		}

		/// <summary>
		/// Updates the current test type in the database.
		/// </summary>
		/// <param name="message">Returns a message describing the result.</param>
		/// <returns>True if update is successful; otherwise, false.</returns>
		public bool UpdateTest(out string message)
		{
			if (TestTypeInfo == null)
			{
				message = "Invalid Test Type";
				return false;
			}

			if (TestTypeValidator.IsTestTypeTitleExistsExcludingItself(TestTypeInfo.Title, TestTypeInfo.ID))
			{
				message = "This Title Already Took By Another Test Type";
				return false;
			}

			TestTypeDTO origin = TestTypeDAL.FindByID(TestTypeInfo.ID);

			if (origin.Title == TestTypeInfo.Title && origin.Description == TestTypeInfo.Description && origin.Fees == TestTypeInfo.Fees)
			{
				message = "No Changes Happened";
				return true;
			}

			if (TestTypeDAL.Update(TestTypeInfo))
			{
				message = "Test Type Updated Successfuly";
				return true;
			}
			else
			{
				message = "Could not update Test Type";
				return false;
			}
		}

		/// <summary>
		/// Deletes a test type by its ID.
		/// </summary>
		/// <param name="testTypeID">The test type ID.</param>
		/// <returns>True if deletion is successful; otherwise, false.</returns>
		public bool DeleteTest(int testTypeID)
		{
			return TestTypeDAL.Delete(testTypeID);
		}
	}
}
