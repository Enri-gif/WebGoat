using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

public class BlogResponsDTO{

    [NotNull]
    [StringLength(50, MinimumLength = 1)]
    [RegularExpression(@"[a-zA-Z]", ErrorMessage = "Invalid Author")]
    public string Author {set; get;}
    [NotNull]
    [StringLength(2400, MinimumLength = 1)]
    [RegularExpression(@"/^(?=[a-zA-Z0-9~@#$^*()_+=[\]{}|\\,.?: -]*$)(?!.*[<>\/;`])", ErrorMessage = "Invalid Content")]
    public string Contents {set; get;}
    [NotNull]
    [RegularExpression(@"\d+", ErrorMessage = "Invalid Id")]
    public int BlogEntryId {set; get;}
    [NotNull]
    [StringLength(50, MinimumLength = 1)]
    [RegularExpression(@"^\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2}$", ErrorMessage = "Invalid Posted date")]
    public DateTime ResponseDate {set; get;}


}