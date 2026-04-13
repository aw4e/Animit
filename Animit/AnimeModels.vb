Friend Class AnimeCardItem
    Public Property Title As String
    Public Property Slug As String
    Public Property Url As String
    Public Property Thumbnail As String
    Public Property Episode As String
    Public Property Type As String
    Public Property Score As String
End Class

Friend Class AnimeDetailItem
    Public Property Title As String
    Public Property Synopsis As String
    Public Property Thumbnail As String
    Public Property Url As String
    Public ReadOnly Property Episodes As New List(Of EpisodeItem)
End Class

Friend Class EpisodeItem
    Public Property Number As String
    Public Property Title As String
    Public Property Slug As String
    Public Property Url As String
    Public Property EpisodeDate As String
End Class

Friend Class EpisodeDetailItem
    Public Property Title As String
    Public Property EpisodeNumber As String
    Public Property ReleaseDate As String
    Public Property Url As String
    Public Property HighestQualityLabel As String
    Public Property ServerChoices As New List(Of ServerChoice)
End Class

Friend Class ServerChoice
    Public Property Label As String
    Public Property AutoplayUrl As String
    Public Property EpisodePageUrl As String
    Public Property QualityRank As Integer
End Class
