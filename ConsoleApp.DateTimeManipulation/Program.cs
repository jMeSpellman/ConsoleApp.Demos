// See https://aka.ms/new-console-template for more information
//Console.WriteLine("********* - DateTime manipulation - *********");

//// Empty DateTime Object
//DateTime dateTime = new DateTime();

//// Create a DateTime from date and time
//var dateOfBirth = new DateTime(1980,12,25);
//Console.WriteLine($"My DOB is : {dateOfBirth}");

//var exactDateAndTimeOfBirth = new DateTime(1980, 12, 25, 14, 45, 25, DateTimeKind.Local);
//Console.WriteLine($"My Excat DOB is : {exactDateAndTimeOfBirth}");

//Console.WriteLine($"Day of the Week: {dateOfBirth.DayOfWeek}");
//Console.WriteLine($"Day of the Year: {dateOfBirth.DayOfYear}");
//Console.WriteLine($"Time of Day: {exactDateAndTimeOfBirth.TimeOfDay}");
//Console.WriteLine($"Tick: {exactDateAndTimeOfBirth.Ticks}");
//Console.WriteLine($"Kind: {exactDateAndTimeOfBirth.Kind}");

// Create a DateTime from current timestamp
using System.Globalization;

DateTime now = DateTime.Now;
//Console.WriteLine($"The Time Now is : {now}");

//// Create a DateTime from a string
//Console.WriteLine("What is your DOB (dd/MM/yyyy): ");
//string dob = Console.ReadLine();
//var userDob = DateTime.Parse( dob );
//Console.WriteLine($"Day of the Week: {userDob.DayOfWeek}");
//Console.WriteLine($"Day of the Year: {userDob.DayOfYear}");
//Console.WriteLine($"Time of Day: {userDob.TimeOfDay}");
//Console.WriteLine($"Tick: {userDob.Ticks}");
//Console.WriteLine($"Kind: {userDob.Kind}");

//// Change Format DateTime
//Console.WriteLine($"Formatted Date: {userDob.ToString("dd/MM/yyyy")}");
//Console.WriteLine($"Formatted Date: {userDob.ToString("MMM dd, yyyy")}");
//Console.WriteLine($"Formatted Date: {userDob.ToString("yyyyMMMdd")}");
//Console.WriteLine($"Formatted Date: {userDob.ToString("dddd, dd MMMM, yyyy")}");

//// Add Additional Time
//Console.WriteLine($"One hour from Now is : {now.AddHours(1)}");
//Console.WriteLine($"One day from Now is : {now.AddDays(1)}");
//Console.WriteLine($"One day ago from Now is : {now.AddDays(-1)}");

//Console.WriteLine("********* - DateTime Offset manipulation - *********");
//// UTC - Co-ordinated Universal Time
//var utcNow = DateTime.UtcNow;
//Console.WriteLine($"Now Date Time is : {now}");
//Console.WriteLine($"UTC Now Date Time is : {utcNow}");

//// DateTime Offset andf TimeZone Info
//var tz = TimeZoneInfo.Local.GetUtcOffset(utcNow);
//Console.WriteLine($"User Time Zone : {tz}");

//var dto = new DateTimeOffset(now, tz);
//Console.WriteLine($"User Time Zone with UTC Offset: {dto}");
//Console.WriteLine($"UTC Time of Action: {dto.UtcDateTime}");

//var indiaTz = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
//var indiaDataTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTz);
//Console.WriteLine($"Action was completed in India at : {indiaDataTime}");

//Console.WriteLine("********* - Date Only Time Only manipulation - *********");

//// DateOnly
//var dateOnly = new DateOnly(1980, 12, 25);
//var nextDay = dateOnly.AddDays(1);
//var previousDay = dateOnly.AddDays(-1);
//var decadeLater = dateOnly.AddYears(10);
//var lastMonth = dateOnly.AddMonths(-1);

//Console.WriteLine($" Date: {dateOnly}");
//Console.WriteLine($" The Next Day: {nextDay}");
//Console.WriteLine($" The Previous Day: {previousDay}");
//Console.WriteLine($" The Decade Later: {decadeLater}");
//Console.WriteLine($" The Last Month: {lastMonth}");

//var dateOnlyFromDateTime = DateOnly.FromDateTime( now );
//Console.WriteLine($"Date Only From DateTime: {dateOnlyFromDateTime}");

//Console.WriteLine("What is you D.O.B (dd MMM yyyy)");
//var dobDateOnly = Console.ReadLine();

//var theDateOnly = DateOnly.ParseExact(dobDateOnly, "dd MMM yyyy", CultureInfo.InvariantCulture);
//Console.WriteLine($"The Date Only: {theDateOnly}");

//// TimeOnly
//var timeNow = TimeOnly.FromDateTime( now );
//Console.WriteLine($"It is now {timeNow}");
//Console.WriteLine($"It is now {timeNow:hh:mm tt}");

// Date Comparisons
var date1 = new DateTime(1970, 04, 10);
var date2 = new DateTime(1963, 12, 5);

Console.WriteLine($"Is '{nameof(date1)}' equal? {date1 == date2}");
Console.WriteLine($"Is '{nameof(date1)}' equal? {date1.Equals(date2)}");
Console.WriteLine($"Is '{nameof(date2)}' after? {date2 > date1}");
Console.WriteLine($"Is '{nameof(date2)}' before? {date2 < date1}");

