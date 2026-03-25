$root = Get-ChildItem -Path '.\*.sql' | ForEach-Object { [PSCustomObject]@{Path=$_.FullName;Hash=(Get-FileHash $_.FullName -Algorithm SHA256).Hash}}
$bc = Get-ChildItem -Path '.\bc\*.sql' | ForEach-Object { [PSCustomObject]@{Path=$_.FullName;Hash=(Get-FileHash $_.FullName -Algorithm SHA256).Hash}}
$dups = foreach ($r in $root) {
    $m = $bc | Where-Object { $_.Hash -eq $r.Hash }
    if ($m) {
        [PSCustomObject]@{Root=$r.Path;BC=$m.Path;Hash=$r.Hash}
    }
}
$dups | Format-Table -AutoSize
$dups | Export-Csv duplicate_files.csv -NoTypeInformation
if ($dups.Count -gt 0) {
    foreach ($d in $dups) {
        Remove-Item -Path $d.Root -Force
        Write-Host "Removed $($d.Root)"
    }
} else {
    Write-Host 'No duplicates found'
}
