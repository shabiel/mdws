#region CopyrightHeader
//
//  Copyright by Contributors
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//         http://www.apache.org/licenses/LICENSE-2.0.txt
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//
#endregion

using System;
using gov.va.medora.mdo;

/// <summary>
/// Summary description for SiteTO
/// </summary>

namespace gov.va.medora.mdws.dto
{
    public class SiteTO : AbstractTO
    {
        public String sitecode = "";
        public String name = "";
        public String displayName = "";
        public String moniker = "";
        public String regionID = "";
        public String lastEventTimestamp = "";
        public String lastEventReason = "";
        public string uid = "";
        public string pid = "";
        public DataSourceArray dataSources;
        public string parentSiteId;
        public SiteArray childSites;
        public string address;
        public string city;
        public string state;
        public string systemName;
        public string siteType;

        public SiteTO() { }

        public SiteTO(Site mdoSite)
        {
            if (mdoSite == null)
            {
                return;
            }
            this.sitecode = mdoSite.Id;
            this.name = mdoSite.Name;
            this.displayName = mdoSite.DisplayName;
            this.moniker = mdoSite.Moniker;
            this.regionID = mdoSite.RegionId;
            this.lastEventTimestamp = mdoSite.LastEventTimestamp;
            this.lastEventReason = mdoSite.LastEventReason;
            if (mdoSite.Sources != null && mdoSite.Sources.Length != 0)
            {
                this.dataSources = new DataSourceArray(mdoSite.Sources);
            }
            this.parentSiteId = mdoSite.ParentSiteId;
            this.address = mdoSite.Address;
            this.city = mdoSite.City;
            this.state = mdoSite.State;
            this.systemName = mdoSite.SystemName;
            this.siteType = mdoSite.SiteType;
            if (mdoSite.ChildSites != null && mdoSite.ChildSites.Length != 0)
            {
                this.childSites = new SiteArray(mdoSite.ChildSites);
            }
        }
    }
}
