#pragma checksum "C:\Users\lauren.sanabria\source\repos\MiddlewareDosPinos\MiddlewareDosPinos\Views\Dashboard\Panel_Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "127f32f46dbc646ea2dd3142d280f28c8acfdf6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Panel_Dashboard), @"mvc.1.0.view", @"/Views/Dashboard/Panel_Dashboard.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\lauren.sanabria\source\repos\MiddlewareDosPinos\MiddlewareDosPinos\Views\_ViewImports.cshtml"
using MiddlewareDosPinos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lauren.sanabria\source\repos\MiddlewareDosPinos\MiddlewareDosPinos\Views\_ViewImports.cshtml"
using MiddlewareDosPinos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"127f32f46dbc646ea2dd3142d280f28c8acfdf6a", @"/Views/Dashboard/Panel_Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d588c82ab846753a1064929f74441e25dd0dbb2", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Panel_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\lauren.sanabria\source\repos\MiddlewareDosPinos\MiddlewareDosPinos\Views\Dashboard\Panel_Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!--Aqu?? va la programaci??n del dashboard -->


<main>
    <div class=""container-fluid px-4"">
        <h1 class=""mt-4"">Dashboard</h1>
        <ol class=""breadcrumb mb-4"">
            <li class=""breadcrumb-item active"">Dashboard</li>
        </ol>
        <div class=""row"">
            <div class=""col-xl-3 col-md-6"">
                <div class=""card bg-primary text-white mb-4"">
                    <div class=""card-body"">Primary Card</div>
                    <div class=""card-footer d-flex align-items-center justify-content-between"">
                        <a class=""small text-white stretched-link"" href=""#"">View Details</a>
                        <div class=""small text-white""><i class=""fas fa-angle-right""></i></div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-3 col-md-6"">
                <div class=""card bg-warning text-white mb-4"">
                    <div class=""card-body"">Warning Card</div>
                    <div class=""card");
            WriteLiteral(@"-footer d-flex align-items-center justify-content-between"">
                        <a class=""small text-white stretched-link"" href=""#"">View Details</a>
                        <div class=""small text-white""><i class=""fas fa-angle-right""></i></div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-3 col-md-6"">
                <div class=""card bg-success text-white mb-4"">
                    <div class=""card-body"">Success Card</div>
                    <div class=""card-footer d-flex align-items-center justify-content-between"">
                        <a class=""small text-white stretched-link"" href=""#"">View Details</a>
                        <div class=""small text-white""><i class=""fas fa-angle-right""></i></div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-3 col-md-6"">
                <div class=""card bg-danger text-white mb-4"">
                    <div class=""card-body"">Danger Card</div>
  ");
            WriteLiteral(@"                  <div class=""card-footer d-flex align-items-center justify-content-between"">
                        <a class=""small text-white stretched-link"" href=""#"">View Details</a>
                        <div class=""small text-white""><i class=""fas fa-angle-right""></i></div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-xl-6"">
                <div class=""card mb-4"">
                    <div class=""card-header"">
                        <i class=""fas fa-chart-area me-1""></i>
                        Area Chart Example
                    </div>
                    <div class=""card-body""><canvas id=""myAreaChart"" width=""100"" height=""40""></canvas></div>
                </div>
            </div>
            <div class=""col-xl-6"">
                <div class=""card mb-4"">
                    <div class=""card-header"">
                        <i class=""fas fa-chart-bar me-1""></i>
                        ");
            WriteLiteral(@"Bar Chart Example
                    </div>
                    <div class=""card-body""><canvas id=""myBarChart"" width=""100"" height=""40""></canvas></div>
                </div>
            </div>
        </div>
        <div class=""card mb-4"">
            <div class=""card-header"">
                <i class=""fas fa-table me-1""></i>
                DataTable Example
            </div>
            <div class=""card-body"">
                <table id=""datatablesSimple"">
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Position</th>
                            <th>Office</th>
                            <th>Age</th>
                            <th>Start date</th>
                            <th>Salary</th>
                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>Name</th>
                            <th>Position</th>
       ");
            WriteLiteral(@"                     <th>Office</th>
                            <th>Age</th>
                            <th>Start date</th>
                            <th>Salary</th>
                        </tr>
                    </tfoot>
                    <tbody>
                        <tr>
                            <td>Tiger Nixon</td>
                            <td>System Architect</td>
                            <td>Edinburgh</td>
                            <td>61</td>
                            <td>2011/04/25</td>
                            <td>$320,800</td>
                        </tr>
                        <tr>
                            <td>Garrett Winters</td>
                            <td>Accountant</td>
                            <td>Tokyo</td>
                            <td>63</td>
                            <td>2011/07/25</td>
                            <td>$170,750</td>
                        </tr>
                        <tr>
                            <td>As");
            WriteLiteral(@"hton Cox</td>
                            <td>Junior Technical Author</td>
                            <td>San Francisco</td>
                            <td>66</td>
                            <td>2009/01/12</td>
                            <td>$86,000</td>
                        </tr>
                        <tr>
                            <td>Cedric Kelly</td>
                            <td>Senior Javascript Developer</td>
                            <td>Edinburgh</td>
                            <td>22</td>
                            <td>2012/03/29</td>
                            <td>$433,060</td>
                        </tr>
                        <tr>
                            <td>Airi Satou</td>
                            <td>Accountant</td>
                            <td>Tokyo</td>
                            <td>33</td>
                            <td>2008/11/28</td>
                            <td>$162,700</td>
                        </tr>
                        <");
            WriteLiteral(@"tr>
                            <td>Brielle Williamson</td>
                            <td>Integration Specialist</td>
                            <td>New York</td>
                            <td>61</td>
                            <td>2012/12/02</td>
                            <td>$372,000</td>
                        </tr>
                        <tr>
                            <td>Herrod Chandler</td>
                            <td>Sales Assistant</td>
                            <td>San Francisco</td>
                            <td>59</td>
                            <td>2012/08/06</td>
                            <td>$137,500</td>
                        </tr>
                        <tr>
                            <td>Rhona Davidson</td>
                            <td>Integration Specialist</td>
                            <td>Tokyo</td>
                            <td>55</td>
                            <td>2010/10/14</td>
                            <td>$327,900</td>
   ");
            WriteLiteral(@"                     </tr>
                        <tr>
                            <td>Colleen Hurst</td>
                            <td>Javascript Developer</td>
                            <td>San Francisco</td>
                            <td>39</td>
                            <td>2009/09/15</td>
                            <td>$205,500</td>
                        </tr>
                        <tr>
                            <td>Sonya Frost</td>
                            <td>Software Engineer</td>
                            <td>Edinburgh</td>
                            <td>23</td>
                            <td>2008/12/13</td>
                            <td>$103,600</td>
                        </tr>
                        <tr>
                            <td>Jena Gaines</td>
                            <td>Office Manager</td>
                            <td>London</td>
                            <td>30</td>
                            <td>2008/12/19</td>
               ");
            WriteLiteral(@"             <td>$90,560</td>
                        </tr>
                        <tr>
                            <td>Quinn Flynn</td>
                            <td>Support Lead</td>
                            <td>Edinburgh</td>
                            <td>22</td>
                            <td>2013/03/03</td>
                            <td>$342,000</td>
                        </tr>
                        <tr>
                            <td>Charde Marshall</td>
                            <td>Regional Director</td>
                            <td>San Francisco</td>
                            <td>36</td>
                            <td>2008/10/16</td>
                            <td>$470,600</td>
                        </tr>
                        <tr>
                            <td>Haley Kennedy</td>
                            <td>Senior Marketing Designer</td>
                            <td>London</td>
                            <td>43</td>
                       ");
            WriteLiteral(@"     <td>2012/12/18</td>
                            <td>$313,500</td>
                        </tr>
                        <tr>
                            <td>Tatyana Fitzpatrick</td>
                            <td>Regional Director</td>
                            <td>London</td>
                            <td>19</td>
                            <td>2010/03/17</td>
                            <td>$385,750</td>
                        </tr>
                        <tr>
                            <td>Michael Silva</td>
                            <td>Marketing Designer</td>
                            <td>London</td>
                            <td>66</td>
                            <td>2012/11/27</td>
                            <td>$198,500</td>
                        </tr>
                        <tr>
                            <td>Paul Byrd</td>
                            <td>Chief Financial Officer (CFO)</td>
                            <td>New York</td>
                  ");
            WriteLiteral(@"          <td>64</td>
                            <td>2010/06/09</td>
                            <td>$725,000</td>
                        </tr>
                        <tr>
                            <td>Gloria Little</td>
                            <td>Systems Administrator</td>
                            <td>New York</td>
                            <td>59</td>
                            <td>2009/04/10</td>
                            <td>$237,500</td>
                        </tr>
                        <tr>
                            <td>Bradley Greer</td>
                            <td>Software Engineer</td>
                            <td>London</td>
                            <td>41</td>
                            <td>2012/10/13</td>
                            <td>$132,000</td>
                        </tr>
                        <tr>
                            <td>Dai Rios</td>
                            <td>Personnel Lead</td>
                            <td>Edin");
            WriteLiteral(@"burgh</td>
                            <td>35</td>
                            <td>2012/09/26</td>
                            <td>$217,500</td>
                        </tr>
                        <tr>
                            <td>Jenette Caldwell</td>
                            <td>Development Lead</td>
                            <td>New York</td>
                            <td>30</td>
                            <td>2011/09/03</td>
                            <td>$345,000</td>
                        </tr>
                        <tr>
                            <td>Yuri Berry</td>
                            <td>Chief Marketing Officer (CMO)</td>
                            <td>New York</td>
                            <td>40</td>
                            <td>2009/06/25</td>
                            <td>$675,000</td>
                        </tr>
                        <tr>
                            <td>Caesar Vance</td>
                            <td>Pre-Sales Supp");
            WriteLiteral(@"ort</td>
                            <td>New York</td>
                            <td>21</td>
                            <td>2011/12/12</td>
                            <td>$106,450</td>
                        </tr>
                        <tr>
                            <td>Doris Wilder</td>
                            <td>Sales Assistant</td>
                            <td>Sidney</td>
                            <td>23</td>
                            <td>2010/09/20</td>
                            <td>$85,600</td>
                        </tr>

                    </tbody>
                </table>
            </div>
        </div>
    </div>
</main>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
