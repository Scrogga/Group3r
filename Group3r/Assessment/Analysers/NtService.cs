﻿using Group3r.Options.AssessmentOptions;
using LibSnaffle.ActiveDirectory;
using System.Collections.Generic;

namespace Group3r.Assessment.Analysers
{
    public class NtServiceAnalyser : Analyser
    {
        public NtServiceSetting setting { get; set; }

        public override SettingResult Analyse(AssessmentOptions assessmentOptions)
        {
            List<GpoFinding> findings = new List<GpoFinding>();

            /*
            findings.Add(new GpoFinding()
            {
                //GpoSetting = setting,
                FindingReason = "NtService analyser not implemented.",
                FindingDetail = "NtService analyser not implemented.",
                Triage = Constants.Triage.Green
            });
            // put findings in settingResult
            SettingResult.Findings = findings;

            // make a new setting object minus the ugly bits we don't care about.
            SettingResult.Setting = new NtServiceSetting();


                            // if the path points to a dir or a file that exist and snaffler deems them interesting, that's a finding on its own, regardless of whether they're modifiable
                if (pathResult.SnaffDirResults.Count > 0)
                {
                    foreach (DirResult dr in pathResult.SnaffDirResults)
                    {
                        if (dr.MatchedRule != null)
                        {
                            if ((int)MinTriage <= (int)dr.Triage)
                            {
                                findings.Add(new GpoFinding()
                                {
                                    PathFindings = new List<PathResult>() { pathResult },
                                    FindingReason =
                                        "The Snaffler engine deemed this directory path interesting on its own.",
                                    FindingDetail = "Matched Path: " + dr.ResultDirInfo.FullName + " Matched Rule: " + dr.MatchedRule.RuleName,
                                    Triage = dr.Triage
                                });
                            }
                        }
                    }
                }
                if (pathResult.SnaffFileResults.Count > 0)
                {
                    foreach (FileResult fr in pathResult.SnaffFileResults)
                    {
                        if (fr.MatchedRule != null)
                        {
                            if ((int)MinTriage <= (int)fr.Triage)
                            {
                                findings.Add(new GpoFinding()
                                {
                                    PathFindings = new List<PathResult>() { pathResult },
                                    FindingReason =
                                        "The Snaffler engine deemed this file path interesting on its own.",
                                    FindingDetail = "Matched Path: " + fr.ResultFileInfo.FullName + " Matched Rule: " + fr.MatchedRule.RuleName + " Match Context: " + fr.TextResult.MatchContext,
                                    Triage = fr.Triage
                                });
                            }
                        }
                    }
                }

            */
            SettingResult.Setting = setting;

            return SettingResult;
        }
    }
}