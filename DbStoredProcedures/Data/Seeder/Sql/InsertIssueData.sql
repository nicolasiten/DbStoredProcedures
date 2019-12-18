USE [IssueTracker]

SET IDENTITY_INSERT [dbo].[Issue] ON 

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (2, 3, 5, 1, 3, N'User says product is buying two of every purchase made. If the user
wishes to buy 10 shares of Apple stock, the product makes two transactions, each for 10
 shares.', CAST(N'2019-12-07T10:30:00.000' AS DateTime), N'User was on a 3G network and expected the purchase to complete
faster than it was. User clicked the Purchase button, then clicked it again when the screen
did not change fast enough. Sent request to Development to add “in progress” animation
when purchases are made and to disable Purchase button after first click.', CAST(N'2019-12-08T11:30:00.000' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (4, 3, 5, 4, 1, N'The user shouts Day Trader Wannabe buttons are not clickable.', CAST(N'2019-12-04T14:15:29.573' AS DateTime), N'test', CAST(N'2019-12-10T17:35:29.573' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (5, 3, 2, 4, 2, N'Premium Plan subscriber describes Workout Planner application is crashing after connection loss.', CAST(N'2019-11-27T14:24:30.023' AS DateTime), N'test', CAST(N'2019-12-06T16:47:30.023' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (6, 2, 2, 3, 1, N'Premium Plan subscriber reports Day Trader Wannabe application shows exception on startup.', CAST(N'2019-12-07T01:22:30.173' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (7, 1, 5, 2, 1, N'Basic Plan subscriber describes Workout Planner application layout looks weird on small mobile screen.', CAST(N'2019-12-11T09:14:30.383' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (8, 1, 3, 1, 2, N'A developer makes clear Social Anxiety Planner application is loading endlessly.', CAST(N'2019-12-11T20:29:30.610' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (9, 2, 6, 1, 3, N'The user shouts Day Trader Wannabe application is not responsive on long operation, not clear if it crashed.', CAST(N'2019-11-27T21:40:30.813' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (10, 1, 3, 3, 2, N'A tester shouts Investment Overlord application is crashing after connection loss.', CAST(N'2019-12-02T06:19:30.947' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (11, 1, 3, 4, 2, N'The user reports Workout Planner application showing OutOfMemory Exception.', CAST(N'2019-12-06T08:42:31.083' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (12, 3, 3, 3, 2, N'Free Plan subscriber says Social Anxiety Planner application freezes sporadically.', CAST(N'2019-11-28T10:40:31.223' AS DateTime), N'test', CAST(N'2019-12-05T21:17:31.223' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (13, 3, 3, 1, 3, N'A developer makes clear Day Trader Wannabe application is not responsive on long operation, not clear if it crashed.', CAST(N'2019-12-02T23:40:31.370' AS DateTime), N'test', CAST(N'2019-12-12T15:19:31.370' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (14, 3, 5, 1, 3, N'A tester reports Day Trader Wannabe application layout looks weird on small mobile screen.', CAST(N'2019-12-06T20:36:28.253' AS DateTime), N'Basic Plan subscriber was having no network connection. Exception will be catched and user will get informed with a dialog.', CAST(N'2019-12-10T02:37:28.253' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (15, 3, 5, 2, 1, N'The user shouts Investment Overlord application is not responsive on long operation, not clear if it crashed.', CAST(N'2019-12-09T04:05:35.087' AS DateTime), N'The user was using an old device with a very limited amount of RAM. Developers will optimize the RAM usage.', CAST(N'2019-12-13T15:05:35.087' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (16, 3, 4, 1, 4, N'A tester makes known Day Trader Wannabe application startup time is extremely slow.', CAST(N'2019-11-27T09:01:35.337' AS DateTime), N'Free Plan subscriber was sending several buy requests because application seemed unresponsive. Show in progress screen on checkout.', CAST(N'2019-12-13T10:13:35.337' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (17, 1, 6, 4, 1, N'Basic Plan subscriber makes known Social Anxiety Planner application is crashing after connection loss.', CAST(N'2019-12-10T12:29:35.637' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (18, 2, 4, 3, 2, N'A tester shouts Workout Planner application is crashing after connection loss.', CAST(N'2019-12-03T15:03:35.767' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (19, 3, 1, 1, 3, N'Free Plan subscriber shouts Day Trader Wannabe application shows exception on startup.', CAST(N'2019-12-06T19:54:35.900' AS DateTime), N'Premium Plan subscriber was using an old device with a very limited amount of RAM. Application is expected to be slower on such a device.', CAST(N'2019-12-13T11:45:35.900' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (20, 1, 3, 3, 2, N'Free Plan subscriber says Workout Planner application is loading endlessly.', CAST(N'2019-11-26T03:06:36.193' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (21, 2, 1, 1, 2, N'Premium Plan subscriber reports Day Trader Wannabe application is crashing after connection loss.', CAST(N'2019-12-02T17:30:36.320' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (22, 1, 5, 3, 5, N'Basic Plan subscriber describes Workout Planner application is crashing after connection loss.', CAST(N'2019-12-13T14:36:36.453' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (23, 2, 5, 3, 2, N'The user makes known Workout Planner application freezes sporadically.', CAST(N'2019-11-30T19:18:36.547' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (24, 2, 2, 3, 2, N'A developer makes clear Workout Planner application layout looks weird on small mobile screen.', CAST(N'2019-11-26T14:14:36.713' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (25, 2, 5, 3, 2, N'Free Plan subscriber says Workout Planner application layout looks weird on small mobile screen.', CAST(N'2019-12-08T00:07:36.860' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (26, 2, 2, 2, 6, N'Free Plan subscriber makes clear Investment Overlord application showing OutOfMemory Exception.', CAST(N'2019-11-28T07:11:36.977' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (27, 3, 4, 2, 5, N'The user says Investment Overlord application is not responsive on long operation, not clear if it crashed.', CAST(N'2019-11-27T15:37:37.147' AS DateTime), N'A developer was having no network connection. Exception will be catched and cached offline data will be shown instead.', CAST(N'2019-11-29T04:45:37.147' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (28, 3, 3, 1, 1, N'Premium Plan subscriber describes Day Trader Wannabe buttons are not clickable.', CAST(N'2019-11-29T08:52:37.403' AS DateTime), N'The user was sending requests over and over again by clicking around. Show in progress screen on long operations.', CAST(N'2019-12-07T07:36:37.403' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (29, 3, 2, 2, 5, N'Basic Plan subscriber makes known Investment Overlord application showing OutOfMemory Exception.', CAST(N'2019-12-06T11:29:37.683' AS DateTime), N'A tester was having no network connection. Exception will be catched and user will get informed with a dialog.', CAST(N'2019-12-09T09:31:37.683' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (30, 2, 3, 3, 2, N'Premium Plan subscriber says Workout Planner application is crashing after connection loss.', CAST(N'2019-12-14T01:35:37.913' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (31, 1, 6, 3, 2, N'The user describes Workout Planner buttons are not clickable.', CAST(N'2019-12-06T14:54:38.020' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (32, 2, 3, 4, 2, N'Basic Plan subscriber shouts Social Anxiety Planner application startup time is extremely slow.', CAST(N'2019-11-27T05:49:38.147' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (33, 2, 6, 1, 3, N'Premium Plan subscriber makes clear Day Trader Wannabe application layout looks weird on small mobile screen.', CAST(N'2019-11-27T20:24:38.317' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (34, 1, 3, 3, 2, N'Basic Plan subscriber reports Workout Planner application startup time is extremely slow.', CAST(N'2019-12-12T17:16:38.423' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (35, 2, 2, 3, 2, N'Premium Plan subscriber describes Workout Planner application layout looks weird on small mobile screen.', CAST(N'2019-12-13T02:44:38.670' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (36, 3, 5, 3, 5, N'A developer shouts Workout Planner application shows exception on startup.', CAST(N'2019-12-12T20:18:34.847' AS DateTime), N'Basic Plan subscriber was using a phone with a cracked screen that is randomly sending click events. User will have to buy a new phone.', CAST(N'2019-12-13T16:22:34.847' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (37, 3, 3, 2, 6, N'Free Plan subscriber says Investment Overlord application layout looks weird on small mobile screen.', CAST(N'2019-12-03T11:21:34.597' AS DateTime), N'The user was using a slow 3G Network. The application will show message that the network is too slow.', CAST(N'2019-12-06T01:26:34.597' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (38, 3, 3, 1, 1, N'Basic Plan subscriber describes Day Trader Wannabe application is not responsive on long operation, not clear if it crashed.', CAST(N'2019-12-12T09:55:34.277' AS DateTime), N'Free Plan subscriber was on a 3G network and expected the operation to complete faster then it was. In Progress animation will be implemented.', CAST(N'2019-12-12T11:21:34.277' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (39, 2, 2, 1, 3, N'Free Plan subscriber describes Day Trader Wannabe buttons are not clickable.', CAST(N'2019-11-27T21:44:34.173' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (40, 3, 4, 1, 4, N'Free Plan subscriber makes clear Day Trader Wannabe application showing OutOfMemory Exception.', CAST(N'2019-12-11T03:17:29.097' AS DateTime), N'Basic Plan subscriber was using an old device with a very limited amount of RAM. Dev team will store less objects in the RAM.', CAST(N'2019-12-11T10:03:29.097' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (41, 3, 2, 3, 1, N'A tester shouts Workout Planner application is crashing after connection loss.', CAST(N'2019-11-25T21:26:29.463' AS DateTime), N'A tester was using a slow 3G Network. The application will be optimize to work with a slow network.', CAST(N'2019-12-12T19:23:29.463' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (42, 3, 3, 1, 4, N'Basic Plan subscriber reports Day Trader Wannabe buttons are not clickable.', CAST(N'2019-12-02T15:04:29.820' AS DateTime), N'The user was using a phone with a cracked screen that is randomly sending click events. User will have to buy a new phone.', CAST(N'2019-12-11T10:32:29.820' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (43, 1, 3, 4, 1, N'A tester makes clear Social Anxiety Planner application is crashing after connection loss.', CAST(N'2019-11-29T02:50:30.137' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (44, 2, 5, 3, 2, N'Free Plan subscriber makes known Workout Planner application freezes sporadically.', CAST(N'2019-11-28T11:28:30.367' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (45, 3, 4, 3, 5, N'A developer describes Workout Planner application layout looks weird on small mobile screen.', CAST(N'2019-12-12T22:57:30.490' AS DateTime), N'The user was on a 3G network and expected the operation to complete faster then it was. In Progress animation will be implemented.', CAST(N'2019-12-13T05:01:30.490' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (46, 2, 2, 1, 3, N'A tester describes Day Trader Wannabe application is not responsive on long operation, not clear if it crashed.', CAST(N'2019-12-09T02:28:30.830' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (47, 1, 1, 1, 2, N'A developer makes known Day Trader Wannabe application is crashing after connection loss.', CAST(N'2019-11-28T00:52:30.977' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (48, 2, 5, 4, 1, N'The user makes known Social Anxiety Planner application is loading endlessly.', CAST(N'2019-12-13T23:35:31.120' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (49, 3, 3, 1, 1, N'Premium Plan subscriber makes clear Day Trader Wannabe application freezes sporadically.', CAST(N'2019-11-25T04:28:31.250' AS DateTime), N'A developer was sending requests over and over again by clicking around. Show in progress screen on long operations.', CAST(N'2019-11-28T07:04:31.250' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (50, 3, 5, 2, 1, N'The user shouts Investment Overlord application startup time is extremely slow.', CAST(N'2019-12-07T01:57:38.780' AS DateTime), N'A developer was using an old device with a very limited amount of RAM. Application is expected to be slower on such a device.', CAST(N'2019-12-14T05:29:38.780' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (51, 3, 1, 1, 3, N'Free Plan subscriber reports Day Trader Wannabe application is not responsive on long operation, not clear if it crashed.', CAST(N'2019-11-27T05:43:31.570' AS DateTime), N'Premium Plan subscriber was using an old device with a very limited amount of RAM. Dev team will store less objects in the RAM.', CAST(N'2019-12-07T10:53:31.570' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (52, 3, 3, 2, 6, N'The user makes clear Investment Overlord application is not responsive on long operation, not clear if it crashed.', CAST(N'2019-12-11T17:08:31.910' AS DateTime), N'A developer was using a phone with a cracked screen that is randomly sending click events. User will have to buy a new phone.', CAST(N'2019-12-12T00:25:31.910' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (53, 2, 3, 1, 4, N'A developer makes known Day Trader Wannabe application shows exception on startup.', CAST(N'2019-11-30T04:13:32.187' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (54, 3, 4, 3, 2, N'Basic Plan subscriber reports Workout Planner application is loading endlessly.', CAST(N'2019-12-01T22:25:32.313' AS DateTime), N'Premium Plan subscriber was having no network connection. Exception will be catched and cached offline data will be shown instead.', CAST(N'2019-12-14T05:45:32.313' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (55, 3, 5, 3, 5, N'Premium Plan subscriber makes clear Workout Planner application is not responsive on long operation, not clear if it crashed.', CAST(N'2019-12-14T08:05:32.610' AS DateTime), N'A tester was sending several buy requests because application seemed unresponsive. Show in progress screen on checkout.', CAST(N'2019-12-14T08:57:32.610' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (56, 3, 5, 1, 4, N'The user shouts Day Trader Wannabe application is loading endlessly.', CAST(N'2019-12-13T02:49:32.847' AS DateTime), N'A developer was using a desktop device with a very small screen. Application will be optimized to work with smaller screens.', CAST(N'2019-12-13T19:38:32.847' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (57, 3, 2, 4, 2, N'The user shouts Social Anxiety Planner buttons are not clickable.', CAST(N'2019-12-03T13:38:33.117' AS DateTime), N'Basic Plan subscriber was sending requests over and over again by clicking around. Show in progress screen on long operations.', CAST(N'2019-12-04T12:24:33.117' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (58, 1, 2, 4, 2, N'The user says Social Anxiety Planner application is not responsive on long operation, not clear if it crashed.', CAST(N'2019-12-08T22:22:33.363' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (59, 3, 6, 3, 2, N'Free Plan subscriber reports Workout Planner application shows exception on startup.', CAST(N'2019-12-08T22:24:33.467' AS DateTime), N'A developer was having no network connection. Exception will be catched and user will get informed with a dialog.', CAST(N'2019-12-13T04:45:33.467' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (60, 3, 3, 1, 3, N'The user makes known Day Trader Wannabe application freezes sporadically.', CAST(N'2019-11-28T22:01:33.760' AS DateTime), N'A developer was using a slow 3G Network. The application will show message that the network is too slow.', CAST(N'2019-12-07T03:51:33.760' AS DateTime))

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (61, 1, 4, 3, 2, N'A developer makes clear Workout Planner buttons are not clickable.', CAST(N'2019-12-13T16:04:34.040' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (62, 1, 6, 1, 3, N'Basic Plan subscriber shouts Day Trader Wannabe application shows exception on startup.', CAST(N'2019-12-14T09:30:31.800' AS DateTime), NULL, NULL)

INSERT [dbo].[Issue] ([Id], [StatusFk], [OperatingSystemFk], [ProductFk], [VersionFk], [Problem], [CreationDate], [Resolution], [ResolutionDate]) VALUES (63, 2, 3, 4, 2, N'Free Plan subscriber shouts Social Anxiety Planner application startup time is extremely slow.', CAST(N'2019-12-03T09:57:39.037' AS DateTime), NULL, NULL)

SET IDENTITY_INSERT [dbo].[Issue] OFF

