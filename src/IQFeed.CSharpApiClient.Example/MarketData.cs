﻿using System.Collections.Generic;

namespace IQFeed.CSharpApiClient.Example
{
    public static class MarketData
    {
        private static readonly List<string> Symbols = new List<string>()
            {
                "SPY",
                "QQQ",
                "EEM",
                "AAPL",
                "BAC",
                "NVDA",
                "NLY",
                "MU",
                "VXX",
                "HYG",
                "AMD",
                "FB",
                "BABA",
                "TSLA",
                "T",
                "TLT",
                "AMZN",
                "SLV",
                "NXPI",
                "PG",
                "EFA",
                "NFLX",
                "CHK",
                "VRX",
                "HD",
                "XLE",
                "SNAP",
                "UVXY",
                "XLF",
                "GE",
                "SYMC",
                "EWZ",
                "M",
                "WFC",
                "C",
                "WLL",
                "USO",
                "IP",
                "WMT",
                "XOP",
                "TWTR",
                "DIA",
                "CAT",
                "VLO",
                "CELG",
                "GOOGL",
                "SMH",
                "JPM",
                "XRT",
                "AMAT",
                "JD",
                "F",
                "VIPS",
                "KO",
                "SQ",
                "FXI",
                "JCP",
                "RIG",
                "PBR",
                "DIS",
                "JCI",
                "XOM",
                "X",
                "TEVA",
                "AAL",
                "ABBV",
                "VZ",
                "FCX",
                "JNUG",
                "WDC",
                "NUGT",
                "WMB",
                "GS",
                "QCOM",
                "LOW",
                "BA",
                "VALE",
                "GOOG",
                "BIDU",
                "MO",
                "AMLP",
                "DDD",
                "TUR",
                "CMCSA",
                "GG",
                "DAL",
                "KRE",
                "PYPL",
                "TGT",
                "V",
                "DVN",
                "DISH",
                "TBT",
                "EWW",
                "XLV",
                "TWX",
                "BLL",
                "CVX",
                "IQ",
                "XLU",
                "NBR",
                "XLP",
                "ROKU",
                "CRM",
                "CL",
                "TMUS",
                "DB",
                "MA",
                "GM",
                "FLO",
                "BMY",
                "A",
                "PFG",
                "ADM",
                "BP",
                "TTD",
                "GILD",
                "UAA",
                "FSLR",
                "EA",
                "IYR",
                "SBUX",
                "MAS",
                "DHI",
                "IBM",
                "EPI",
                "MCD",
                "XLI",
                "GPS",
                "HMNY",
                "TRN",
                "ADBE",
                "PM",
                "COST",
                "LLY",
                "ABX",
                "MS",
                "BGCP",
                "CVS",
                "NEM",
                "SPG",
                "PFE",
                "XBI",
                "COP",
                "NYCB",
                "ORCL",
                "PSTG",
                "BRK B",
                "ATVI",
                "BBT",
                "APC",
                "WHR",
                "CMG",
                "ITUB",
                "UPS",
                "AFL",
                "BK",
                "JNJ",
                "SQQQ",
                "MDT",
                "UAL",
                "SLB",
                "WYNN",
                "CBS",
                "RF",
                "TQQQ",
                "WB",
                "MRK",
                "BKNG",
                "MRO",
                "MGM",
                "LRCX",
                "TTWO",
                "AMGN",
                "DWDP",
                "XLK",
                "MSCC",
                "DE",
                "CLF",
                "AVGO",
                "VOD",
                "KSS",
                "AKS",
                "NTES",
                "HSY",
                "ASH",
                "GME",
                "BZUN",
                "CX",
                "UA",
                "HBI",
                "DG",
                "NKE",
                "XNET",
                "HAL",
                "DUST",
                "EWJ",
                "AMT",
                "P",
                "ARWR",
                "PGR",
                "RDS A",
                "IBB",
                "EOG",
                "BB",
                "BOX",
                "KHC",
                "STX",
                "MAT",
                "SDRL",
                "NWL",
                "NTNX",
                "TZA",
                "SVXY",
                "DKS",
                "FOXA",
                "TMV",
                "PEP",
                "BUD",
                "UUP",
                "GLW",
                "EBAY",
                "FDX",
                "FCAU",
                "QID",
                "HPQ",
                "SC",
                "EPD",
                "SNE",
                "OMER",
                "SCHW",
                "RSX",
                "ADSK",
                "COF",
                "BBY",
                "UNH",
                "CAR",
                "NE",
                "VSM",
                "TXN",
                "YELP",
                "LULU",
                "USB",
                "CRC",
                "TWLO",
                "PENN",
                "CA",
                "SO",
                "AA",
                "SHOP",
                "RIO",
                "IMMR",
                "AIG",
                "CTL",
                "STM",
                "XRX",
                "KMI",
                "LMT",
                "SPOT",
                "ADI",
                "XHB",
                "BBBY",
                "SGMO",
                "CBOE",
                "ISRG",
                "HUM",
                "TRXC",
                "SGMS",
                "MYL",
                "SPXL",
                "ABT",
                "SHLD",
                "AMRS",
                "WBA",
                "CRON",
                "OPK",
                "DBX",
                "LVS",
                "MDLZ",
                "JNPR",
                "UNP",
                "SWN",
                "TTM",
                "S",
                "LUV",
                "OXY",
                "AXP",
                "LEN",
                "AGN",
                "AAXN",
                "YNDX",
                "FAS",
                "WFT",
                "SDS",
                "BERY",
                "CTRP",
                "CSX",
                "DUK",
                "GT",
                "ITB",
                "MEET",
                "WTW",
                "RHT",
                "ASNA",
                "TJX",
                "ETP",
                "DFS",
                "CZR",
                "MTCH",
                "ALK",
                "OSTK",
                "MELI",
                "OIH",
                "TSS",
                "LB",
                "AMBA",
                "AUY",
                "REGN",
                "CF",
                "SCHN",
                "ACIA",
                "SHAK",
                "SKX",
                "RTN",
                "UTX",
                "LQD",
                "UPRO",
                "MMM",
                "SORL",
                "MPC",
                "EMB",
                "GRPN",
                "ESV",
                "O",
                "SIRI",
                "HLF",
                "BG",
                "CLX",
                "AEM",
                "ADT",
                "TRIP",
                "ULTA",
                "DVA",
                "ADP",
                "HES",
                "HPE",
                "LABU",
                "BYD",
                "ZION",
                "HCLP",
                "CPB",
                "MRVL",
                "TNA",
                "BIIB",
                "SPLK",
                "GERN",
                "AKRX",
                "RUN",
                "AXDX",
                "FOSL",
                "WPM",
                "JWN",
                "RDS B",
                "SPWR",
                "PHM",
                "BPL",
                "SCO",
                "LNG",
                "VIRT",
                "URI",
                "JBLU",
                "XLB",
                "NOK",
                "MOMO",
                "FBHS",
                "HSBC",
                "APA",
                "ALGN",
                "CTSH",
                "OKE",
                "UNG",
                "AYX",
                "NOW",
                "HTHT",
                "HL",
                "SEDG",
                "AGO",
                "WRK",
                "KR",
                "STLD",
                "OLED",
                "ARNA",
                "ELLI",
                "BX",
                "CBB",
                "DLTR",
                "CCJ",
                "KBH",
                "RL",
                "SPXU",
                "RCII",
                "FANG",
                "JDST",
                "UNIT",
                "NEPT",
                "BLUE",
                "AERI",
                "AMTD",
                "IMMU",
                "GIS",
                "ETFC",
                "AABA",
                "EXEL",
                "STZ",
                "HON",
                "EPE",
                "NAV",
                "PPG",
                "RH",
                "PSEC",
                "SOXL",
                "OAS",
                "FTR",
                "CPA",
                "KNX",
                "NOC",
                "GOOS",
                "YPF",
                "VMW",
                "CSIQ",
                "PVTL",
                "BSX",
                "AAOI",
                "KERX",
                "AKAM",
                "ERX",
                "XLNX",
                "CREE",
                "MDXG",
                "EAT",
                "HOLI",
                "NUE",
                "PZZA",
                "SBLK",
                "CVNA",
                "FEZ",
                "Z",
                "SWKS",
                "SMRT",
                "FIT",
                "CIEN",
                "FEYE",
                "PVH",
                "HIMX",
                "DXD",
                "MT",
                "ADMP",
                "TOL",
                "FLR",
                "CARS",
                "ALB",
                "TPX",
                "AEO",
                "RIOT",
                "CSCO",
                "VSTM",
                "VNOM",
                "IGT",
                "FOLD",
                "WSM",
                "MET",
                "MNST",
                "SHLX",
                "SAP",
                "ALXN",
                "NRG",
                "SINA",
                "CI",
                "AG",
                "I",
                "NKTR",
                "IFF",
                "APRN",
                "TMO",
                "SLCA",
                "XLY",
                "NTAP",
                "UCO",
                "NVO",
                "XON",
                "AER",
                "WDAY",
                "FBP",
                "GIII",
                "CLMT",
                "EL",
                "TSM",
                "JEC",
                "MNKD",
                "EXP",
                "ANET",
                "YY",
                "CRSP",
                "STI",
                "HFC",
                "DRI",
                "AVAV",
                "MBI",
                "MASI",
                "SRPT",
                "GNW",
                "KODK",
                "RRC",
                "PPL",
                "PLCE",
                "CRBP",
                "SSO",
                "QD",
                "HOG",
                "PANW",
                "PPC",
                "TKR",
                "WATT",
                "KEY",
                "OCLR",
                "CRZO",
                "GGAL",
                "ESPR",
                "CVE",
                "KORS",
                "XPO",
                "MXIM",
                "CWH",
                "CLR",
                "EXPE",
                "FL",
                "PLAY",
                "EPC",
                "VRTX",
                "CMI",
                "EMR",
                "RAD",
                "HTZ",
                "MDR",
                "SM",
                "EDU",
                "MDCO",
                "CAKE",
                "CSOD",
                "ZTO",
                "MOS",
                "HLTH",
                "IONS",
                "ANTM",
                "PAYC",
                "TSCO",
                "SN",
                "SYF",
                "HHC",
                "ONVO",
                "RCL",
                "QLD",
                "CBM",
                "TMF",
                "SPHS",
                "IEF",
                "MTZ",
                "NHTC",
                "RMTI",
                "PSX",
                "FMC",
                "CVRR",
                "DXC",
                "W",
                "PRU",
                "FITB",
                "AMBC",
                "ON",
                "IBN",
                "PAAS",
                "PLUG",
                "WRD",
                "ETSY",
                "DHR",
                "LGCY",
                "GSK",
                "GRUB",
                "TD",
                "NOV",
                "CME",
                "UDOW",
                "URBN",
                "RDN",
                "CENX",
                "VIAB",
                "FMSA",
                "AZN",
                "LBTYA",
                "MCHP",
                "IWM",
                "FND",
                "BHP",
                "INO",
                "CCL",
                "KKR",
                "PTLA",
                "CY",
                "FAST",
                "ANF",
                "BLKB",
                "PXD",
                "GD",
                "STMP",
                "PF",
                "TSN",
                "BMRN",
                "TECK",
                "ANDV",
                "ESRX",
                "TAP",
                "FXB",
                "VRSN",
                "CHL",
                "ILMN",
                "KSA",
                "K",
                "CQP",
                "LITE",
                "LUK",
                "BWA",
                "MZOR",
                "IRBT",
                "ASML",
                "YRD",
                "EZA",
                "EMN",
                "OKTA",
                "BHF",
                "MSG",
                "AZO",
                "HQY",
                "LGIH",
                "GBT",
                "BLK",
                "AAP",
                "VEEV",
                "TRGP",
                "IDTI",
                "RNG",
                "ED",
                "GRMN",
                "CPRT",
                "FLS",
                "PCG",
                "PII",
                "WM",
                "KWEB",
                "NVS",
                "IWO",
                "IEP",
                "MCHI",
                "NTR",
                "FISV",
                "MLM",
                "PAYX",
                "HP",
                "VNQ",
                "WES",
                "SH",
                "NFX",
                "YINN",
                "AN",
                "MTDR",
                "MLCO",
                "CC",
                "MAC",
                "QRVO",
                "ATRA",
                "SEE",
                "TDOC",
                "HUBS",
                "ABMD",
                "WYN",
                "FLT",
                "OLLI",
                "D",
                "BAX",
                "GOLD",
                "CNI",
                "DQ",
                "CHDN",
                "EXAS",
                "VTR",
                "NXST",
                "INCY",
                "SAFM",
                "EDC",
                "KLAC",
                "MSI",
                "VFC",
                "GWW",
                "MKC",
                "EIX",
                "CERN",
                "UTHR",
                "DNKN",
                "QDEL",
                "UBNT",
                "CHTR",
                "KSU",
                "AEP",
                "OC",
                "CFR",
                "KMX",
                "GDDY",
                "SJM",
                "ATHM",
                "PLD",
                "FTNT",
                "CTXS",
                "SUPN",
                "SGEN",
                "USCR",
                "IWD",
                "DPZ",
                "TEAM",
                "ITRI",
                "IPGP",
                "KMB",
                "TOT",
                "IDXX",
                "EGRX",
                "UN",
                "TXT",
                "MHK",
                "TYL",
                "PVAC",
                "MGA",
                "ORLY",
                "LNC",
                "BDX",
                "NOAH",
                "TREE",
                "PSA",
                "EQIX",
                "MEOH",
                "SIX",
                "IART",
                "SHW",
                "MMP",
                "SIVB",
                "SAM",
                "MKL",
                "MDY",
                "ITA",
                "MTN",
                "ADS",
                "SPGI",
                "SRCL",
                "CDK",
                "ULTI",
                "VOO",
                "LEA",
                "ROP",
                "ESS",
                "HII",
                "COO",
                "FDS",
                "TDG",
                "MKTX",
                "IVV",
                "MTD",
                "CHE",
                "WCG",
                "RE",
                "LFUS",
                "CACC",
                "NEU",
                "BIO",
                "GLD",
                "INTC",
                "FXE",
                "GPRO",
                "MSFT",
                "ZAYO",
                "FIVE",
                "GDXJ",
                "DXJ",
                "SWCH",
                "GDX",
                "SPXS"
            };

        public static IEnumerable<string> GetSymbols()
        {
            return Symbols;
        }
    }
}