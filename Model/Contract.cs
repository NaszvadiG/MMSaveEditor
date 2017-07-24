﻿
using FullSerializer;
using System;

[fsObject(MemberSerialization = fsMemberSerialization.OptOut)]
public class Contract
{
    public Contract.Job job = Contract.Job.Unemployed;
    public DateTime startDate = new DateTime();
    private DateTime mEndDate = new DateTime();
    private Contract.ContractStatus mContractStatus = Contract.ContractStatus.OnGoing;
    public Action OnOptionClauseEnd;
    protected CalendarEvent_v1 mCalendarEvent;

    public Contract.ContractStatus contractStatus
    {
        get
        {
            return this.mContractStatus;
        }
    }

    public enum ContractStatus
    {
        InProposalState,
        OnGoing,
        InOptionClause,
        Terminated,
    }

    public enum Job
    {
        [LocalisationID("PSG_10003547")] Driver,
        [LocalisationID("PSG_10003548")] Staff,
        [LocalisationID("PSG_10003549")] Engineer,
        [LocalisationID("PSG_10004602")] EngineerLead,
        [LocalisationID("PSG_10009360")] TeamAssistant,
        [LocalisationID("PSG_10003552")] TeamPrincipal,
        [LocalisationID("PSG_10003553")] Scout,
        [LocalisationID("PSG_10003554")] Mechanic,
        [LocalisationID("PSG_10003555")] Chairman,
        [LocalisationID("PSG_10007918")] IMAPresident,
        [LocalisationID("PSG_10003556")] PrivateInvestigator,
        [LocalisationID("PSG_10003557")] Photographer,
        [LocalisationID("PSG_10003558")] BookKeeper,
        [LocalisationID("PSG_10003559")] Barrister,
        [LocalisationID("PSG_10003560")] Actor,
        [LocalisationID("PSG_10003561")] SponsorLiasion,
        [LocalisationID("PSG_10003562")] Journalist,
        [LocalisationID("PSG_10005269")] Fan,
        [LocalisationID("PSG_10003563")] Unemployed,
        [LocalisationID("PSG_10003555")] InvestorChairman,
    }

    public enum ContractTerminationType
    {
        Generic,
        ContractElapsed,
        FiredByPlayer,
        HiredBySomeoneElse,
        IsRetiring,
    }
}
