// valuetypes cannot be null (for example DateTime)
// nullable types can be done using Nullable<T> or by using a '?'

DateTime? date = null;

//nullable has preset methods
Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
Console.WriteLine("HasValue: " + date.HasValue);

//nulable to non-nullable can be done using GetValueOrDefault()
DateTime? date2 = DateTime.Now;
DateTime date3 = date2.GetValueOrDefault();

//with tertiary operator
DateTime date4 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

Console.WriteLine(date4);