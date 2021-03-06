﻿namespace Microsoft.SfB.PlatformService.SDK.ClientModel
{
    public enum AudioVideoFlowCapability
    {
        PlayPrompt
    }

    public enum PromptCapability
    {
    }

    public enum AudioVideoCallCapability
    {
        Establish,
        Transfer,
        Terminate
    }

    public enum MessagingCallCapability
    {
        Establish,
        SendMessage,
        Terminate
    }

    public enum TransferCapability
    {
    }

    public enum ConversationCapability
    {
        AddParticipant
    }

    public enum ConversationConferenceCapability
    {
        Terminate
    }

    public enum ConversationBridgeCapability
    {
        AddBridgedParticipant
    }

    internal enum ParticipantsCapability
    {
    }

    public enum BridgedParticipantsCapability
    {
    }

    public enum BridgedParticipantCapability
    {
    }

    public enum ParticipantCapability
    {
    }

    public enum ParticipantMessagingCapability
    {
    }

    public enum ApplicationCapability
    {
        GetAnonApplicationToken,
        GetAdhocMeetingResource
    }

    public enum CommunicationCapability
    {
        StartMessaging,
        StartMessagingWithIdentity,
        StartAudioVideo,
        StartAudio
    }

    public enum MessagingInvitationCapability
    {
        StartAdhocMeeting,
        AcceptAndBridge
    }

    public enum AudioVideoInvitationCapability
    {
        Accept,
        Forward,
        Decline
    }

    public enum OnlineMeetingInvitationCapability
    {
    }

    public enum ParticipantInvitationCapability
    {
    }

    public enum ApplicationsCapability
    {
    }

    public enum DiscoverCapability
    {
    }
}
