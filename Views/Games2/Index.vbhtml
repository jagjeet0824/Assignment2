@ModelType IEnumerable(Of Assignment2.Games2)
@Code
ViewData("Title") = "Index"
End Code
<style>
body{
	background-color:black;
    color:darkgoldenrod;
}
	</style>
<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Awards)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Vocal)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Onstage)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Awards)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Vocal)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Onstage)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Best_singer }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Best_singer }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Best_singer })
        </td>
    </tr>
Next

</table>
