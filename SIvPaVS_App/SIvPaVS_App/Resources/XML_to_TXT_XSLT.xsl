<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0" xmlns:ex="http://exslt.org/common" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text"/>

  <xsl:template match="text()" />

  <xsl:template match="receipt">
    <xsl:text>&#09;&#09;Pokladničný blok&#xd;&#xd;</xsl:text>

    <xsl:apply-templates select="provider"/>

    <xsl:text>&#xd;Čas:&#09;&#09;&#09;</xsl:text>
    <xsl:value-of select="issued-at"/>
    <xsl:text>&#xd;</xsl:text>
    <xsl:text>Kód reg. pokladnice:&#09;</xsl:text>
    <xsl:value-of select="tax-code"/>
    <xsl:text>&#xd;&#xd;</xsl:text>

    <xsl:apply-templates select="items" />

    <xsl:variable name="products">
      <xsl:call-template name="GetSum">
        <xsl:with-param name="left" select="//items"/>
      </xsl:call-template>
    </xsl:variable>

    <xsl:text>&#xd;Sadzba DPH:&#09;</xsl:text>
    <xsl:value-of select="tax-percentage"/>
    <xsl:text>&#32;%</xsl:text>
    <xsl:text>&#xd;Základ DPH:&#09;</xsl:text>
    <xsl:value-of select="sum(ex:node-set($products)/product)-((sum(ex:node-set($products)/product) div 100)*tax-percentage)"/>
    <xsl:text>&#32;EUR</xsl:text>
    <xsl:text>&#xd;DPH:&#09;&#09;</xsl:text>
    <xsl:value-of select="(sum(ex:node-set($products)/product) div 100)*tax-percentage"/>
    <xsl:text>&#32;EUR&#xd;</xsl:text>
    <xsl:text>&#xd;CELKOM:&#09;&#09;</xsl:text>
    <xsl:value-of select="sum(ex:node-set($products)/product)"/>
    <xsl:text>&#32;EUR</xsl:text>
  </xsl:template>

  <xsl:template match="provider">
    <xsl:text>Spoločnosť&#xd;</xsl:text>
    <xsl:text>&#32;&#32;Názov:&#09;</xsl:text>
    <xsl:value-of select="name"/>
    <xsl:text>&#xd;</xsl:text>
    <xsl:text>&#32;&#32;IČO:&#09;&#09;</xsl:text>
    <xsl:value-of select="company-reg-num" />
    <xsl:text>&#xd;</xsl:text>
    <xsl:text>&#32;&#32;IČ DPH:&#09;</xsl:text>
    <xsl:value-of select="vat-reg-num" />
    <xsl:text>&#xd;</xsl:text>
    <xsl:text>&#xd;&#32;&#32;Adresa&#xd;</xsl:text>
    <xsl:text>&#32;&#32;&#32;&#32;Ulica:&#09;</xsl:text>
    <xsl:value-of select="address/street" />
    <xsl:text>&#xd;</xsl:text>
    <xsl:text>&#32;&#32;&#32;&#32;Mesto:&#09;</xsl:text>
    <xsl:value-of select="address/city" />
    <xsl:text>&#xd;</xsl:text>
    <xsl:text>&#32;&#32;&#32;&#32;PSČ:&#09;</xsl:text>
    <xsl:value-of select="address/zip" />
    <xsl:text>&#xd;</xsl:text>
    <xsl:text>&#32;&#32;&#32;&#32;Štát:&#09;</xsl:text>
    <xsl:value-of select="address/country" />
    <xsl:text>&#xd;</xsl:text>
  </xsl:template>

  <xsl:template match="items">
    <xsl:for-each select="item">
      <xsl:value-of select="name"/>
      <xsl:text>&#xd;</xsl:text>
      <xsl:text>&#32;&#32;</xsl:text>
      <xsl:value-of select="quantity"/>
      <xsl:text>&#32;</xsl:text>
      <xsl:value-of select="quantity-type"/>
      <xsl:text>&#32;&#32;x&#32;&#32;</xsl:text>
      <xsl:value-of select="price"/>
      <xsl:text>&#32;EUR</xsl:text>
      <xsl:text>&#32;&#32;.....&#32;&#32;</xsl:text>
      <xsl:value-of select="quantity * price"/>
      <xsl:text>&#32;EUR&#xd;&#xd;</xsl:text>
    </xsl:for-each>
  </xsl:template>

  <xsl:template name="GetSum">
    <xsl:param name="items"/>

    <xsl:for-each select="items/item">
      <product>
        <xsl:value-of select="quantity * price"/>
      </product>
    </xsl:for-each>
  </xsl:template>

</xsl:stylesheet>