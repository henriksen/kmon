kpm build --configuration release
$latestNupkg = Get-ChildItem -Exclude *symbols* bin\release\*.nupkg | sort-object name -descending | select -First 1
nuget push $latestNupkg.FullName