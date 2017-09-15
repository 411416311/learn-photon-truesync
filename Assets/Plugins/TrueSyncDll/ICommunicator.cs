using System;

// ͨ���� �ӿ�
public interface ICommunicator
{
    // ����ʱ�� / �ӳ�
	int RoundTripTime();

    // �����¼�
	void OpRaiseEvent(byte eventCode, object message, bool reliable, int[] toPlayers);

    // �����¼�
	void AddEventListener(OnEventReceived onEventReceived);
}
