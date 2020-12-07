<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<body>
				<p><h2>Students in dormitory list</h2></p>
				<table border="2">
					<tr>
						<th>FirstName</th>
						<th>LastName</th>
						<th>Faculty</th>
						<th>Specialization</th>
						<th>Course</th>
						<th>Room</th>
						<th>WhenCheckedInto</th>
					</tr>
					
					<xsl:for-each select = "Dormitory/Student">
						<tr>
							<td>
								<xsl:value-of select="@FirstName"/>
							</td>
							<td>
								<xsl:value-of select="@LastName"/>
							</td>
							<td>
								<xsl:value-of select="@Faculty"/>
							</td>
							<td>
								<xsl:value-of select="@Specialization"/>
							</td>
							<td>
								<xsl:value-of select="@Course"/>
							</td>
							<td>
								<xsl:value-of select="@Room"/>
							</td>
							<td>
								<xsl:value-of select="@WhenCheckedInto"/>
							</td>
						</tr>
					</xsl:for-each>
					
				</table>
			</body>
		</html>
	            
    </xsl:template>
</xsl:stylesheet>
