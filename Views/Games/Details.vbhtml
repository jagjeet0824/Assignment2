@ModelType ass1.Game
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Awards }) |
    @Html.ActionLink("Back to List", "Index")
</p>
