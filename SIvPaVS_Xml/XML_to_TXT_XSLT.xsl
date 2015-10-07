<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text"/>

  <xsl:template match="text()" />
  
  <xsl:template match="/">
	  <xsl:for-each select="receipts/receipt">      
      <xsl:apply-templates />
      <xsl:text>&#xd;</xsl:text>
		  <xsl:value-of select="issued-at"/>
      <xsl:text>&#xd;</xsl:text>
		  <xsl:value-of select="tax-code"/>
	  </xsl:for-each>
  </xsl:template>

  <xsl:template match="provider">
  	<xsl:value-of select="name"/><xsl:text>&#xd;</xsl:text>
	  <xsl:value-of select="address/street" /><xsl:text>&#xd;</xsl:text>
	  <xsl:value-of select="address/city" /><xsl:text>&#xd;</xsl:text>
	  <xsl:value-of select="address/zip" /><xsl:text>&#xd;</xsl:text>
	  <xsl:value-of select="address/country" /><xsl:text>&#xd;</xsl:text>
	  <xsl:value-of select="company-reg-num" /><xsl:text>&#xd;</xsl:text>
	  <xsl:value-of select="vat-reg-num" /><xsl:text>&#xa;&#xd;</xsl:text>
  </xsl:template>

  <xsl:template match="items">
	  <xsl:for-each select="item">
  		<xsl:value-of select="name"/><xsl:text>&#x9;</xsl:text>
      <xsl:value-of select="quantity"/><xsl:text>&#x9;</xsl:text>
      <xsl:value-of select="price"/><xsl:text>&#xd;</xsl:text>
    </xsl:for-each>
  </xsl:template>

</xsl:stylesheet>