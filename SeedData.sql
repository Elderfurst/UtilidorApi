use spaceforce

insert into utilities values ('Academy Catalog Data Generator');
insert into utilities values ('Bazaar Voice Product Feed Generator');
insert into utilities values ('Booster Questions Learner Notifications');
insert into utilities values ('CE Broker Upload');
insert into utilities values ('CE Quick Training Alerts');
insert into utilities values ('Course Changes Admin Email');
insert into utilities values ('Course Enrollment Instructor Emails');
insert into utilities values ('Course Enrollment Learner Emails');
insert into utilities values ('Course Enrollment Supervisor Emails');
insert into utilities values ('Course Session Attendances Emails');
insert into utilities values ('Course Session Reminder Emails');
insert into utilities values ('Course Swap');
insert into utilities values ('Data Export');
insert into utilities values ('Document Edit Alert Editors Emails');
insert into utilities values ('Document Edit Alert Owner Emails');
insert into utilities values ('Document Edit Alert Owners Emails');
insert into utilities values ('Document Revision Date Alert Emails');
insert into utilities values ('Document Warning Learner Emails');
insert into utilities values ('External Course Enrollments Pending Email');
insert into utilities values ('File Import');
insert into utilities values ('Game Leaderboard Calculations');
insert into utilities values ('License and Certification Reminder Emails');
insert into utilities values ('Manual Warning Emails');
insert into utilities values ('Process Auto Enrollment Queue Record');
insert into utilities values ('Process Course Enrollment Queue');
insert into utilities values ('Process Course Swap Queue Record');
insert into utilities values ('Process Curriculum Enrollment Queue');
insert into utilities values ('Queue Course Warning Emails');
insert into utilities values ('Queue Courses to Swap');
insert into utilities values ('Queue Scheduled Report Emails');
insert into utilities values ('Recorded Performance Review Emails');
insert into utilities values ('Requirements Tracker Emails');
insert into utilities values ('SCORM PowerPoint Coverter');
insert into utilities values ('Send Learner Course Warning Emails');
insert into utilities values ('Send Push Notifications for Course Warning Emails');
insert into utilities values ('Send Scheduled Report Emails');
insert into utilities values ('Send Supervisor Course Warning Emails');
insert into utilities values ('SFTP Helper');
insert into utilities values ('Streaming Media Conversion Failure Email');
insert into utilities values ('Streaming Media Delete from Vimeo');
insert into utilities values ('Training Plan Enrollment Close');
insert into utilities values ('Vimeo Quota Email');
insert into utilities values ('Win SCP');

insert into instances (utilityid, starttime, numerator, denominator) values (1, '2018-09-28 9:25:00', 350, 843);
insert into instances (utilityid, starttime, numerator, denominator) values (27, '2018-09-28 9:15:32', 17, 24);
insert into instances (utilityid, starttime, numerator, denominator) values (23, '2018-09-28 7:45:17', 9, 247);
insert into instances (utilityid, starttime, numerator, denominator) values (21, '2018-09-28 2:15:00', 698, 702);
insert into instances (utilityid, starttime, numerator, denominator) values (5, '2018-09-28 9:45:12', 200, 350);


insert into logs (instanceid, timestamp, level, message) values (2064, '2018-09-28 9:25:01', 0, 'Beginning execution');
insert into logs (instanceid, timestamp, level, message) values (2064, '2018-09-28 9:25:15', 0, 'Processed organization with id 567');
insert into logs (instanceid, timestamp, level, message) values (2064, '2018-09-28 9:25:45', 2, 'Could not process file for organization with id 900: Error while validating user with id 10245');
insert into logs (instanceid, timestamp, level, message) values (2064, '2018-09-28 9:26:04', 0, 'Processed organization with id 2344');
insert into logs (instanceid, timestamp, level, message) values (2064, '2018-09-28 9:27:15', 0, 'Processed organization with id 34589');
insert into logs (instanceid, timestamp, level, message) values (2064, '2018-09-28 9:27:38', 1, '3 users for organization with id 57574 could not be processed, but the file completely successfully');
insert into logs (instanceid, timestamp, level, message) values (2064, '2018-09-28 9:28:17', 0, 'Processed organizationwith id 12');
insert into logs (instanceid, timestamp, level, message) values (2064, '2018-09-28 9:29:53', 0, 'Processed organization with id 999');
insert into logs (instanceid, timestamp, level, message) values (2064, '2018-09-28 9:30:01', 2, 'Could not process for organization with id 8: too many people test with this organization');

insert into logs (instanceid, timestamp, level, message) values (2065, '2018-09-28 9:15:33', 0, 'Beginning execution');
insert into logs (instanceid, timestamp, level, message) values (2065, '2018-09-28 9:15:35', 0, 'Processed course enrollment for user with id 10121');
insert into logs (instanceid, timestamp, level, message) values (2065, '2018-09-28 9:15:51', 1, 'Duplicate course enrollment detected, will not be processed for user with id 1');
insert into logs (instanceid, timestamp, level, message) values (2065, '2018-09-28 9:16:01', 0, 'Processed course enrollment for user with id 3465');
insert into logs (instanceid, timestamp, level, message) values (2065, '2018-09-28 9:16:14', 0, 'Processed course enrollment for user with id 875');
insert into logs (instanceid, timestamp, level, message) values (2065, '2018-09-28 9:17:00', 2, 'Unable to process course enrollment for user with id 538: Course does not exist');
insert into logs (instanceid, timestamp, level, message) values (2065, '2018-09-28 9:17:53', 0, 'Processed course enrollment for user with i 913547');

insert into logs (instanceid, timestamp, level, message) values (2066, '2018-09-28 7:45:18', 0, 'Beginning execution');
insert into logs (instanceid, timestamp, level, message) values (2066, '2018-09-28 7:45:20', 0, 'Email successfully sent to learner with id 9001');
insert into logs (instanceid, timestamp, level, message) values (2066, '2018-09-28 7:45:25', 2, 'Email failed to send to learner with id -900: Invalid user id');
insert into logs (instanceid, timestamp, level, message) values (2066, '2018-09-28 7:45:38', 0, 'Email successfully sent to learner with id 200');
insert into logs (instanceid, timestamp, level, message) values (2066, '2018-09-28 7:46:00', 0, 'Email successfully sent to learner with id 80235985');
insert into logs (instanceid, timestamp, level, message) values (2066, '2018-09-28 7:46:32', 0, 'Email successfully sent to learner with id 2');

insert into logs (instanceid, timestamp, level, message) values (2067, '2018-09-28 2:15:01', 0, 'Beginning execution');
insert into logs (instanceid, timestamp, level, message) values (2067, '2018-09-28 2:15:05', 0, 'Leaderboards updated for organization with id 8');
insert into logs (instanceid, timestamp, level, message) values (2067, '2018-09-28 2:15:59', 1, 'Some users were not included in calculations for organization with id 10121');
insert into logs (instanceid, timestamp, level, message) values (2067, '2018-09-28 2:16:42', 0, 'Leaderboards updated for organization with id 900');
insert into logs (instanceid, timestamp, level, message) values (2067, '2018-09-28 2:17:03', 0, 'Leaderboards updated for organization with id 6534');
insert into logs (instanceid, timestamp, level, message) values (2067, '2018-09-28 2:18:33', 0, 'Leaderboards updated for organization with id 11');
insert into logs (instanceid, timestamp, level, message) values (2067, '2018-09-28 2:19:59', 0, 'Leaderboards updated for organization with id 9001');
insert into logs (instanceid, timestamp, level, message) values (2067, '2018-09-28 2:25:12', 2, 'Leaderboard failed to update for organization with id 69: Calculations timed out');
insert into logs (instanceid, timestamp, level, message) values (2067, '2018-09-28 2:26:03', 0, 'Leaderboards updated for organization with id 659');

insert into logs (instanceid, timestamp, level, message) values (2068, '2018-09-28 9:45:13', 0, 'Beginning execution');
insert into logs (instanceid, timestamp, level, message) values (2068, '2018-09-28 9:45:25', 0, 'CE Broker uploaded');
insert into logs (instanceid, timestamp, level, message) values (2068, '2018-09-28 9:46:03', 1, 'CE Broker appears to have invalid values');
insert into logs (instanceid, timestamp, level, message) values (2068, '2018-09-28 9:47:47', 0, 'CE Broker uploaded');
insert into logs (instanceid, timestamp, level, message) values (2068, '2018-09-28 9:48:03', 0, 'CE Broker uploaded');
insert into logs (instanceid, timestamp, level, message) values (2068, '2018-09-28 9:51:42', 2, 'CE Broker failed to upload');
insert into logs (instanceid, timestamp, level, message) values (2068, '2018-09-28 9:52:54', 0, 'CE Broker uploaded');
