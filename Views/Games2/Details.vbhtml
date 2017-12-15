@ModelType ass1.Games2
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Games2</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Awards)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Awards)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Vocal)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Vocal)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Onstage)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Onstage)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Best_singer }) |
    @Html.ActionLink("Back to List", "Index")
</p>
