﻿function OnMouseOver()
{
GetComponent.<Renderer>().material.shader = Shader.Find("Self-Illumin/Outlined Diffuse");
}

function OnMouseExit()
{
GetComponent.<Renderer>().material.shader = Shader.Find("Legacy Shaders/Transparent/Diffuse");
}