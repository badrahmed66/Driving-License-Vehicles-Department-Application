using System;

namespace MyDVLD_DAL.StoredProcedure
{
  public static class TestTypeProcedures
  {
		/// <summary>
		/// Retrieves all test types.
		/// </summary>
		/// <returns>List of all test types</returns>
		public const string Retrieve = "TestTypes_Retrieve";

		/// <summary>
		/// Retrieves a test type by its ID.
		/// </summary>
		/// <param name="testTypeID">ID of the test type to find</param>
		/// <returns>TestType record</returns>
		public const string FindByID = "TestTypes_FindTestByID";

		/// <summary>
		/// Adds a new test type.
		/// </summary>
		/// <param name="testTypeTitle">Title of the test type</param>
		/// <param name="testTypeDescription">Description of the test type</param>
		/// <param name="testTypeFees">Fees associated with the test type</param>
		/// <returns>Newly created TestType ID</returns>
		public const string Add = "TestTypes_AddNewTestType";

		/// <summary>
		/// Updates an existing test type.
		/// </summary>
		/// <param name="testTypeTitle">Title of the test type</param>
		/// <param name="testTypeDescription">Description of the test type</param>
		/// <param name="testTypeFees">Fees for the test type</param>
		/// <param name="testTypeID">ID of the test type to update</param>
		public const string Update = "TestTypes_Update";

		/// <summary>
		/// Checks if a test type exists by its title.
		/// </summary>
		/// <param name="testTypeTitle">Title of the test type</param>
		/// <returns>1 if exists, 0 otherwise</returns>

		public const string IsExistsByTitle = "TestTypes_IsTestExistsByTitle";

		/// <summary>
		/// Checks if a test type title exists for another test type excluding itself.
		/// </summary>
		/// <param name="testTypeTitle">Title of the test type</param>
		/// <param name="testTypeID">ID of the test type to exclude</param>
		/// <returns>1 if exists in another record, 0 otherwise</returns>
		public const string IsTstExistsExcludingItself=
      "TestTypes_IsTestTypeTitleExiststExcludingItself";

		/// <summary>
		/// Deletes a test type by its ID.
		/// </summary>
		/// <param name="testTypeID">ID of the test type to delete</param>
		/// <returns>None</returns>
		public const string Delete = "TestTypes_Delete";
  }
}