<?cs include:"header.cs" ?>
<div id="add-box">
<form id="upload" method="post" enctype="multipart/form-data" action="<?cs var:CGI.ScriptName ?>?cmd=add">

<p>Select the torrent you wish to add.<br />
<label for="torrent_file">From your computer :</label>
<input type="file" name="torrent_file" id="torrent_file" size="50" /><br />

<label for="torrent_url">From an URL :</label>
<input type="text" name="torrent_url" id="torrent_url" size="50" /><br /><br />

<input type="checkbox" name="start" id="start" value="1" checked="checked" />
<label for="start">Automatically start the torrent.</label><br />

<input type="checkbox" name="topdir" id="topdir" value="1" checked="checked" />
<label for="topdir">Append the torrent top directory (if any) to the content path.</label><br /><br />

<input type="submit" value="Add Torrent" />
<input type="hidden" name="submited" value="1" /></p>
</form>
</div>
<?cs include:"footer.cs" ?>
