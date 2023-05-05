#### Create an application that manages an educational platform for a school using C#, WPF, and SQLServer 2019 or newer. The application must be structured using the MVVM model

##### Four types of users will be able to work on the application

• The application administrator
• Teachers
• Class teachers
• Students

##### I. The administrator is responsible for adding, modifying, and deleting students, teachers, subjects, specializations, and more (CRUD operations on all tables). They will also be responsible for creating associations between

a. Years of study, specializations, and subjects (e.g. year of study: 10th grade – specialization: math and computer science – subjects for 10th-grade math and computer science);
b. Teacher, subject, and class;
c. Students, years of study, and specializations (e.g. John Smith – 10th grade – math and computer science).

The administrator will also be able to remove a student from a class, modify a teacher for a subject or class, and add or replace a class teacher (a class can have only one class teacher at a time).

##### II. A teacher can have two roles: a regular teacher and a class teacher. As a regular teacher, they will have access only to the classes and subjects they teach. They will be able to perform the following operations

a. View, add, and motivate absences (by student + subject + semester)
b. View, add, and cancel grades (same as above)
c. View, add, and delete teaching materials (by subject and semester)
The addition of teaching materials will be restricted only to a specific type of file.
d. Calculate averages – only with the intervention of the teacher (note which subjects have a final exam!)
The average cannot be completed until at least 3 grades and the final exam have been entered (It will be known in advance which subjects have a final exam and which do not. Note: This will be specified when creating the pairing between subject and class. For example, math has a final exam in the 11th-grade math and computer science class, while it does not have a final exam in the 11th-grade social science class). A grade cannot be cancelled once the average has been calculated.

##### III. The class teacher can perform the following operations in addition to those of a regular teacher

a. Motivate absences for the students in the class they teach, regardless of the subject
b. View all absences of a student for a selected subject
c. View unexcused absences of a student for a selected subject
d. View final averages of a student (averages per semester for each subject and the overall average)
e. View the class ranking based on averages (a list with the names of the students and their overall averages)
f. View top-performing students (first, second, third place and honorable mention), students with failing grades (student name + subject name), and repeating students (student name + subjects to be retaken)
g. Display students who have been expelled due to absences (over a predetermined number of absences per semester).
Final situations can only be viewed if all averages have been calculated. The class teacher will not have access to the teacher menu. If they want to add absences or grades, they will have to log in as a teacher.

##### IV. Students will be able to view

a. Teaching materials for each subject in their class
b. Grades for each subject (only their own)
c. Absences for each subject (only their own)
d. Averages for each subject + overall average (only their own and only if calculated)
