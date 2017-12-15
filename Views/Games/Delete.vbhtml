@ModelType ass1.Game
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Game</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Music)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Music)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Movies)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Movies)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Playlist)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Playlist)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
