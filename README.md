# RealmObjectVM

RealmObject��ViewModel�̎�������������B

# History

## ViewModel : RealmObject

        public string Name { get; set; }

�Ƃ����set�Ńg�����U�N�V�����������̂ŗ�����B
get�͕��ʂɓ����B

�o�b�N�X�g�A��private�������ō���
private��public�ŕʂ̖��O�ɂȂ��Ė�������B

�������瓱���o�����̂̓o�b�N�X�g�A��Realm�ō���āA
�o�b�N�X�g�A���C���X�^���X�Ŏ���ViewModel��
RealmObject�ł͂Ȃ��N���X�ō��Ƃ������ƁB
�ǂ����Ƃ��قƂ�ǂȂ��B

## InstanceState : RealmObject

BizLogic�ŕK�v�Ƃ���s�����σf�[�^��Realm�ɂ��B
ViewModel�͏]���ʂ�����TwoWay/OneWay�f�[�^�́A
�o�b�N�X�g�A��Realm�Q�Ƃ���B
�g�����U�N�V�����͂����ō��B

Realm����̃C�x���g��ViewModel�ŏI�[���āA
ViewModel�̃C�x���g�ɕϊ�����Invoke����B
�ʓ|�ɂȂ��������ŋ�J������Ȃ��B

�G���g���[�V�[�g�݂�����
�y�[�W�P�ʂŃR�~�b�g�ł���A�v���Ȃ�A
�R�~�b�g����Realm�ۑ��ŕ����ł���B
����͊��S�ɍ��܂ł̃X�^�C���̉i�����u�������B
�������̂ق����܂��킩��₷���B

�����A�v���̂悤��
���A���^�C���ŉi�����������A�v���̏ꍇ�́A
ViewModel:RealmObject�^����{�ɂ��āA
�������͕͂ʂɍ��̂��ǂ������B
���͊������_��Command�_�@��Realm�ɕۑ������
�����͎c����B
