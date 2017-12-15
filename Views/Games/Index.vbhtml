@ModelType IEnumerable(Of Assignment2.Game)
@Code
ViewData("Title") = "Index"
End Code
<style>
	body {
	background-color:black;
color:darkgoldenrod;	}

</style>

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Music)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Movies)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Playlist)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Music)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Movies)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Playlist)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Awards }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Awards }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Awards })
        </td>
    </tr>
Next

</table>
