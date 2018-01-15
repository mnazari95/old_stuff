using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSolutions___Prototype1___SB
{
    class Queries
    {
        //fields
        private int projectId;

        public Queries() { }
        //Sets the projectId variable to the appropriate index for interfacing with the database.
        public Queries(int projectId)
        {
            this.projectId = projectId;
        }

        //Each method that follows contains an SQL query that is used at some point in the application. The Queries.cs class is used
        //when retrieving anfd updating data in the database.

        public string getEditProjectQueryOne()
        {
            return "SELECT project.project_id, project.project_name, project.project_short_description,"
                                                + " customer.client_name, project.project_start_date FROM project"
                                                + " INNER JOIN customer ON project.client_id = customer.client_id"
                                                + " WHERE project.project_id = " + projectId
                                                + " GROUP BY project.project_id"
                                                + " ORDER BY project.project_id;";
        }

        public string getEditProjectQueryTwo()
        {
            return "SELECT project.employee_id, material.material_name, material.material_price, project.hours_worked FROM task"
                                               + " INNER JOIN material ON task.material_id = material.material_id"
                                               + " INNER JOIN project ON task.project_id = project.project_id"
                                               + " INNER JOIN employee ON project.employee_id = employee.employee_id"
                                               + " WHERE project.project_id = " + projectId
                                               + " GROUP BY employee_name"
                                               + " ORDER BY task_id;";
        }

        public string getEditProjectQueryThree()
        {
            return "SELECT task.task_description, task.task_hours_to_complete, task.employee_id FROM software_eng_db_1.task"
                                + " INNER JOIN project ON task.project_id = project.project_id"
                                + " WHERE project.project_id = " + projectId + ";";
        }

        public string getMainScreenQuery()
        {
            return "Select project.project_id, project.project_name, customer.client_name," +
                                               "project.project_short_description, project.project_start_date From project" +
                                               " INNER JOIN customer ON customer.client_id = project.client_id";
        }

        public string getHoursWorkedQuery()
        {
            return "UPDATE software_eng_db_1.project"
                   + " SET project.hours_worked = (SELECT SUM(task.task_hours_to_complete) FROM software_eng_db_1.task"
                   + " WHERE project_id = " + projectId + ")"
                   + " WHERE project_id = " + projectId + ";";
        }
    }
}
