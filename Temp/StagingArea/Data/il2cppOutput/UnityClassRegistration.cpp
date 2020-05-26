extern "C" void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_SharedInternals();
	RegisterModule_SharedInternals();

	void RegisterModule_Core();
	RegisterModule_Core();

	void RegisterModule_Animation();
	RegisterModule_Animation();

	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_Director();
	RegisterModule_Director();

	void RegisterModule_Grid();
	RegisterModule_Grid();

	void RegisterModule_ParticleSystem();
	RegisterModule_ParticleSystem();

	void RegisterModule_Physics();
	RegisterModule_Physics();

	void RegisterModule_Physics2D();
	RegisterModule_Physics2D();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

	void RegisterModule_Tilemap();
	RegisterModule_Tilemap();

	void RegisterModule_UI();
	RegisterModule_UI();

	void RegisterModule_UnityConnect();
	RegisterModule_UnityConnect();

	void RegisterModule_UnityWebRequest();
	RegisterModule_UnityWebRequest();

	void RegisterModule_Video();
	RegisterModule_Video();

	void RegisterModule_InputLegacy();
	RegisterModule_InputLegacy();

	void RegisterModule_IMGUI();
	RegisterModule_IMGUI();

	void RegisterModule_VFX();
	RegisterModule_VFX();

	void RegisterModule_JSONSerialize();
	RegisterModule_JSONSerialize();

	void RegisterModule_XR();
	RegisterModule_XR();

	void RegisterModule_UnityAnalytics();
	RegisterModule_UnityAnalytics();

	void RegisterModule_TextCore();
	RegisterModule_TextCore();

	void RegisterModule_Input();
	RegisterModule_Input();

	void RegisterModule_VR();
	RegisterModule_VR();

	void RegisterModule_TLS();
	RegisterModule_TLS();

	void RegisterModule_WebGL();
	RegisterModule_WebGL();

}

template <typename T> void RegisterUnityClass(const char*);
template <typename T> void RegisterStrippedType(int, const char*, const char*);

void InvokeRegisterStaticallyLinkedModuleClasses()
{
	// Do nothing (we're in stripping mode)
}

namespace ObjectProduceTestTypes { class Derived; } 
namespace ObjectProduceTestTypes { class SubDerived; } 
class EditorExtension; template <> void RegisterUnityClass<EditorExtension>(const char*);
namespace Unity { class Component; } template <> void RegisterUnityClass<Unity::Component>(const char*);
class Behaviour; template <> void RegisterUnityClass<Behaviour>(const char*);
class Animation; template <> void RegisterUnityClass<Animation>(const char*);
class Animator; template <> void RegisterUnityClass<Animator>(const char*);
class AudioBehaviour; template <> void RegisterUnityClass<AudioBehaviour>(const char*);
class AudioListener; template <> void RegisterUnityClass<AudioListener>(const char*);
class AudioSource; template <> void RegisterUnityClass<AudioSource>(const char*);
class AudioFilter; 
class AudioChorusFilter; 
class AudioDistortionFilter; 
class AudioEchoFilter; 
class AudioHighPassFilter; 
class AudioLowPassFilter; 
class AudioReverbFilter; 
class AudioReverbZone; 
class Camera; template <> void RegisterUnityClass<Camera>(const char*);
namespace UI { class Canvas; } template <> void RegisterUnityClass<UI::Canvas>(const char*);
namespace UI { class CanvasGroup; } template <> void RegisterUnityClass<UI::CanvasGroup>(const char*);
namespace Unity { class Cloth; } 
class Collider2D; template <> void RegisterUnityClass<Collider2D>(const char*);
class BoxCollider2D; template <> void RegisterUnityClass<BoxCollider2D>(const char*);
class CapsuleCollider2D; template <> void RegisterUnityClass<CapsuleCollider2D>(const char*);
class CircleCollider2D; template <> void RegisterUnityClass<CircleCollider2D>(const char*);
class CompositeCollider2D; template <> void RegisterUnityClass<CompositeCollider2D>(const char*);
class EdgeCollider2D; 
class PolygonCollider2D; template <> void RegisterUnityClass<PolygonCollider2D>(const char*);
class TilemapCollider2D; 
class ConstantForce; 
class Effector2D; template <> void RegisterUnityClass<Effector2D>(const char*);
class AreaEffector2D; 
class BuoyancyEffector2D; 
class PlatformEffector2D; 
class PointEffector2D; 
class SurfaceEffector2D; template <> void RegisterUnityClass<SurfaceEffector2D>(const char*);
class FlareLayer; 
class GUIElement; template <> void RegisterUnityClass<GUIElement>(const char*);
namespace TextRenderingPrivate { class GUIText; } 
class GUITexture; 
class GUILayer; template <> void RegisterUnityClass<GUILayer>(const char*);
class GridLayout; template <> void RegisterUnityClass<GridLayout>(const char*);
class Grid; template <> void RegisterUnityClass<Grid>(const char*);
class Tilemap; template <> void RegisterUnityClass<Tilemap>(const char*);
class Halo; 
class HaloLayer; 
class IConstraint; 
class AimConstraint; 
class LookAtConstraint; 
class ParentConstraint; 
class PositionConstraint; 
class RotationConstraint; 
class ScaleConstraint; 
class Joint2D; template <> void RegisterUnityClass<Joint2D>(const char*);
class AnchoredJoint2D; template <> void RegisterUnityClass<AnchoredJoint2D>(const char*);
class DistanceJoint2D; 
class FixedJoint2D; template <> void RegisterUnityClass<FixedJoint2D>(const char*);
class FrictionJoint2D; 
class HingeJoint2D; template <> void RegisterUnityClass<HingeJoint2D>(const char*);
class SliderJoint2D; 
class SpringJoint2D; template <> void RegisterUnityClass<SpringJoint2D>(const char*);
class WheelJoint2D; 
class RelativeJoint2D; 
class TargetJoint2D; 
class LensFlare; 
class Light; template <> void RegisterUnityClass<Light>(const char*);
class LightProbeGroup; 
class LightProbeProxyVolume; 
class MonoBehaviour; template <> void RegisterUnityClass<MonoBehaviour>(const char*);
class NavMeshAgent; 
class NavMeshObstacle; 
class OffMeshLink; 
class ParticleSystemForceField; 
class PhysicsUpdateBehaviour2D; 
class ConstantForce2D; 
class PlayableDirector; template <> void RegisterUnityClass<PlayableDirector>(const char*);
class Projector; 
class ReflectionProbe; template <> void RegisterUnityClass<ReflectionProbe>(const char*);
class Skybox; 
class SortingGroup; 
class StreamingController; 
class Terrain; 
class VideoPlayer; template <> void RegisterUnityClass<VideoPlayer>(const char*);
class VisualEffect; 
class WindZone; 
namespace UI { class CanvasRenderer; } template <> void RegisterUnityClass<UI::CanvasRenderer>(const char*);
class Collider; template <> void RegisterUnityClass<Collider>(const char*);
class BoxCollider; template <> void RegisterUnityClass<BoxCollider>(const char*);
class CapsuleCollider; template <> void RegisterUnityClass<CapsuleCollider>(const char*);
class CharacterController; 
class MeshCollider; template <> void RegisterUnityClass<MeshCollider>(const char*);
class SphereCollider; template <> void RegisterUnityClass<SphereCollider>(const char*);
class TerrainCollider; 
class WheelCollider; 
class FakeComponent; 
namespace Unity { class Joint; } 
namespace Unity { class CharacterJoint; } 
namespace Unity { class ConfigurableJoint; } 
namespace Unity { class FixedJoint; } 
namespace Unity { class HingeJoint; } 
namespace Unity { class SpringJoint; } 
class LODGroup; 
class MeshFilter; template <> void RegisterUnityClass<MeshFilter>(const char*);
class OcclusionArea; 
class OcclusionPortal; 
class ParticleSystem; template <> void RegisterUnityClass<ParticleSystem>(const char*);
class Renderer; template <> void RegisterUnityClass<Renderer>(const char*);
class BillboardRenderer; 
class LineRenderer; template <> void RegisterUnityClass<LineRenderer>(const char*);
class RendererFake; 
class MeshRenderer; template <> void RegisterUnityClass<MeshRenderer>(const char*);
class ParticleSystemRenderer; template <> void RegisterUnityClass<ParticleSystemRenderer>(const char*);
class SkinnedMeshRenderer; 
class SpriteMask; 
class SpriteRenderer; template <> void RegisterUnityClass<SpriteRenderer>(const char*);
class SpriteShapeRenderer; 
class TilemapRenderer; template <> void RegisterUnityClass<TilemapRenderer>(const char*);
class TrailRenderer; 
class VFXRenderer; 
class Rigidbody; template <> void RegisterUnityClass<Rigidbody>(const char*);
class Rigidbody2D; template <> void RegisterUnityClass<Rigidbody2D>(const char*);
namespace TextRenderingPrivate { class TextMesh; } template <> void RegisterUnityClass<TextRenderingPrivate::TextMesh>(const char*);
class Transform; template <> void RegisterUnityClass<Transform>(const char*);
namespace UI { class RectTransform; } template <> void RegisterUnityClass<UI::RectTransform>(const char*);
class Tree; 
class GameObject; template <> void RegisterUnityClass<GameObject>(const char*);
class NamedObject; template <> void RegisterUnityClass<NamedObject>(const char*);
class AssetBundle; 
class AssetBundleManifest; 
class ScriptedImporter; 
class AudioMixer; 
class AudioMixerController; 
class AudioMixerGroup; 
class AudioMixerGroupController; 
class AudioMixerSnapshot; 
class AudioMixerSnapshotController; 
class Avatar; 
class AvatarMask; template <> void RegisterUnityClass<AvatarMask>(const char*);
class BillboardAsset; 
class ComputeShader; template <> void RegisterUnityClass<ComputeShader>(const char*);
class Flare; 
namespace TextRendering { class Font; } template <> void RegisterUnityClass<TextRendering::Font>(const char*);
class GameObjectRecorder; 
class LightProbes; 
class LocalizationAsset; 
class Material; template <> void RegisterUnityClass<Material>(const char*);
class ProceduralMaterial; 
class Mesh; template <> void RegisterUnityClass<Mesh>(const char*);
class Motion; template <> void RegisterUnityClass<Motion>(const char*);
class AnimationClip; template <> void RegisterUnityClass<AnimationClip>(const char*);
class PreviewAnimationClip; 
class NavMeshData; 
class OcclusionCullingData; 
class PhysicMaterial; 
class PhysicsMaterial2D; template <> void RegisterUnityClass<PhysicsMaterial2D>(const char*);
class PreloadData; template <> void RegisterUnityClass<PreloadData>(const char*);
class RuntimeAnimatorController; template <> void RegisterUnityClass<RuntimeAnimatorController>(const char*);
class AnimatorController; 
class AnimatorOverrideController; template <> void RegisterUnityClass<AnimatorOverrideController>(const char*);
class SampleClip; template <> void RegisterUnityClass<SampleClip>(const char*);
class AudioClip; template <> void RegisterUnityClass<AudioClip>(const char*);
class Shader; template <> void RegisterUnityClass<Shader>(const char*);
class ShaderVariantCollection; 
class SpeedTreeWindAsset; 
class Sprite; template <> void RegisterUnityClass<Sprite>(const char*);
class SpriteAtlas; template <> void RegisterUnityClass<SpriteAtlas>(const char*);
class SubstanceArchive; 
class TerrainData; 
class TerrainLayer; 
class TextAsset; template <> void RegisterUnityClass<TextAsset>(const char*);
class CGProgram; template <> void RegisterUnityClass<CGProgram>(const char*);
class MonoScript; template <> void RegisterUnityClass<MonoScript>(const char*);
class Texture; template <> void RegisterUnityClass<Texture>(const char*);
class BaseVideoTexture; 
class WebCamTexture; 
class CubemapArray; template <> void RegisterUnityClass<CubemapArray>(const char*);
class LowerResBlitTexture; template <> void RegisterUnityClass<LowerResBlitTexture>(const char*);
class ProceduralTexture; 
class RenderTexture; template <> void RegisterUnityClass<RenderTexture>(const char*);
class CustomRenderTexture; 
class SparseTexture; 
class Texture2D; template <> void RegisterUnityClass<Texture2D>(const char*);
class Cubemap; template <> void RegisterUnityClass<Cubemap>(const char*);
class Texture2DArray; template <> void RegisterUnityClass<Texture2DArray>(const char*);
class Texture3D; template <> void RegisterUnityClass<Texture3D>(const char*);
class VideoClip; 
class VisualEffectObject; 
class VisualEffectAsset; 
class VisualEffectSubgraph; 
class VisualEffectSubgraphBlock; 
class VisualEffectSubgraphOperator; 
class VisualEffectResource; 
class EmptyObject; 
class GameManager; template <> void RegisterUnityClass<GameManager>(const char*);
class GlobalGameManager; template <> void RegisterUnityClass<GlobalGameManager>(const char*);
class AudioManager; template <> void RegisterUnityClass<AudioManager>(const char*);
class BuildSettings; template <> void RegisterUnityClass<BuildSettings>(const char*);
class DelayedCallManager; template <> void RegisterUnityClass<DelayedCallManager>(const char*);
class GraphicsSettings; template <> void RegisterUnityClass<GraphicsSettings>(const char*);
class InputManager; template <> void RegisterUnityClass<InputManager>(const char*);
class MonoManager; template <> void RegisterUnityClass<MonoManager>(const char*);
class NavMeshProjectSettings; 
class Physics2DSettings; template <> void RegisterUnityClass<Physics2DSettings>(const char*);
class PhysicsManager; template <> void RegisterUnityClass<PhysicsManager>(const char*);
class PlayerSettings; template <> void RegisterUnityClass<PlayerSettings>(const char*);
class QualitySettings; template <> void RegisterUnityClass<QualitySettings>(const char*);
class ResourceManager; template <> void RegisterUnityClass<ResourceManager>(const char*);
class RuntimeInitializeOnLoadManager; template <> void RegisterUnityClass<RuntimeInitializeOnLoadManager>(const char*);
class ScriptMapper; template <> void RegisterUnityClass<ScriptMapper>(const char*);
class StreamingManager; 
class TagManager; template <> void RegisterUnityClass<TagManager>(const char*);
class TimeManager; template <> void RegisterUnityClass<TimeManager>(const char*);
class UnityConnectSettings; template <> void RegisterUnityClass<UnityConnectSettings>(const char*);
class VFXManager; template <> void RegisterUnityClass<VFXManager>(const char*);
class LevelGameManager; template <> void RegisterUnityClass<LevelGameManager>(const char*);
class LightmapSettings; template <> void RegisterUnityClass<LightmapSettings>(const char*);
class NavMeshSettings; 
class OcclusionCullingSettings; 
class RenderSettings; template <> void RegisterUnityClass<RenderSettings>(const char*);
class NativeObjectType; 
class PropertyModificationsTargetTestObject; 
class SerializableManagedHost; 
class SerializableManagedRefTestClass; 
namespace ObjectProduceTestTypes { class SiblingDerived; } 
class TestObjectVectorPairStringBool; 
class TestObjectWithSerializedAnimationCurve; 
class TestObjectWithSerializedArray; 
class TestObjectWithSerializedMapStringBool; 
class TestObjectWithSerializedMapStringNonAlignedStruct; 
class TestObjectWithSpecialLayoutOne; 
class TestObjectWithSpecialLayoutTwo; 

void RegisterAllClasses()
{
void RegisterBuiltinTypes();
RegisterBuiltinTypes();
	//Total: 104 non stripped classes
	//0. Camera
	RegisterUnityClass<Camera>("Core");
	//1. Behaviour
	RegisterUnityClass<Behaviour>("Core");
	//2. Unity::Component
	RegisterUnityClass<Unity::Component>("Core");
	//3. EditorExtension
	RegisterUnityClass<EditorExtension>("Core");
	//4. ReflectionProbe
	RegisterUnityClass<ReflectionProbe>("Core");
	//5. QualitySettings
	RegisterUnityClass<QualitySettings>("Core");
	//6. GlobalGameManager
	RegisterUnityClass<GlobalGameManager>("Core");
	//7. GameManager
	RegisterUnityClass<GameManager>("Core");
	//8. LineRenderer
	RegisterUnityClass<LineRenderer>("Core");
	//9. Renderer
	RegisterUnityClass<Renderer>("Core");
	//10. RenderSettings
	RegisterUnityClass<RenderSettings>("Core");
	//11. LevelGameManager
	RegisterUnityClass<LevelGameManager>("Core");
	//12. Shader
	RegisterUnityClass<Shader>("Core");
	//13. NamedObject
	RegisterUnityClass<NamedObject>("Core");
	//14. Material
	RegisterUnityClass<Material>("Core");
	//15. Light
	RegisterUnityClass<Light>("Core");
	//16. MeshFilter
	RegisterUnityClass<MeshFilter>("Core");
	//17. MeshRenderer
	RegisterUnityClass<MeshRenderer>("Core");
	//18. GraphicsSettings
	RegisterUnityClass<GraphicsSettings>("Core");
	//19. Mesh
	RegisterUnityClass<Mesh>("Core");
	//20. Texture
	RegisterUnityClass<Texture>("Core");
	//21. Texture2D
	RegisterUnityClass<Texture2D>("Core");
	//22. Cubemap
	RegisterUnityClass<Cubemap>("Core");
	//23. Texture3D
	RegisterUnityClass<Texture3D>("Core");
	//24. Texture2DArray
	RegisterUnityClass<Texture2DArray>("Core");
	//25. CubemapArray
	RegisterUnityClass<CubemapArray>("Core");
	//26. RenderTexture
	RegisterUnityClass<RenderTexture>("Core");
	//27. GUIElement
	RegisterUnityClass<GUIElement>("Core");
	//28. GUILayer
	RegisterUnityClass<GUILayer>("Core");
	//29. GameObject
	RegisterUnityClass<GameObject>("Core");
	//30. MonoBehaviour
	RegisterUnityClass<MonoBehaviour>("Core");
	//31. TextAsset
	RegisterUnityClass<TextAsset>("Core");
	//32. ComputeShader
	RegisterUnityClass<ComputeShader>("Core");
	//33. LowerResBlitTexture
	RegisterUnityClass<LowerResBlitTexture>("Core");
	//34. PreloadData
	RegisterUnityClass<PreloadData>("Core");
	//35. UI::RectTransform
	RegisterUnityClass<UI::RectTransform>("Core");
	//36. Transform
	RegisterUnityClass<Transform>("Core");
	//37. SpriteRenderer
	RegisterUnityClass<SpriteRenderer>("Core");
	//38. Sprite
	RegisterUnityClass<Sprite>("Core");
	//39. SpriteAtlas
	RegisterUnityClass<SpriteAtlas>("Core");
	//40. AudioClip
	RegisterUnityClass<AudioClip>("Audio");
	//41. SampleClip
	RegisterUnityClass<SampleClip>("Audio");
	//42. AudioSource
	RegisterUnityClass<AudioSource>("Audio");
	//43. AudioBehaviour
	RegisterUnityClass<AudioBehaviour>("Audio");
	//44. Rigidbody
	RegisterUnityClass<Rigidbody>("Physics");
	//45. Collider
	RegisterUnityClass<Collider>("Physics");
	//46. MeshCollider
	RegisterUnityClass<MeshCollider>("Physics");
	//47. BoxCollider
	RegisterUnityClass<BoxCollider>("Physics");
	//48. SphereCollider
	RegisterUnityClass<SphereCollider>("Physics");
	//49. UI::CanvasGroup
	RegisterUnityClass<UI::CanvasGroup>("UI");
	//50. UI::CanvasRenderer
	RegisterUnityClass<UI::CanvasRenderer>("UI");
	//51. UI::Canvas
	RegisterUnityClass<UI::Canvas>("UI");
	//52. TextRenderingPrivate::TextMesh
	RegisterUnityClass<TextRenderingPrivate::TextMesh>("TextRendering");
	//53. TextRendering::Font
	RegisterUnityClass<TextRendering::Font>("TextRendering");
	//54. Rigidbody2D
	RegisterUnityClass<Rigidbody2D>("Physics2D");
	//55. Collider2D
	RegisterUnityClass<Collider2D>("Physics2D");
	//56. PolygonCollider2D
	RegisterUnityClass<PolygonCollider2D>("Physics2D");
	//57. CompositeCollider2D
	RegisterUnityClass<CompositeCollider2D>("Physics2D");
	//58. Joint2D
	RegisterUnityClass<Joint2D>("Physics2D");
	//59. HingeJoint2D
	RegisterUnityClass<HingeJoint2D>("Physics2D");
	//60. AnchoredJoint2D
	RegisterUnityClass<AnchoredJoint2D>("Physics2D");
	//61. AnimationClip
	RegisterUnityClass<AnimationClip>("Animation");
	//62. Motion
	RegisterUnityClass<Motion>("Animation");
	//63. Animator
	RegisterUnityClass<Animator>("Animation");
	//64. AnimatorOverrideController
	RegisterUnityClass<AnimatorOverrideController>("Animation");
	//65. RuntimeAnimatorController
	RegisterUnityClass<RuntimeAnimatorController>("Animation");
	//66. Animation
	RegisterUnityClass<Animation>("Animation");
	//67. VFXManager
	RegisterUnityClass<VFXManager>("VFX");
	//68. InputManager
	RegisterUnityClass<InputManager>("Core");
	//69. VideoPlayer
	RegisterUnityClass<VideoPlayer>("Video");
	//70. PlayableDirector
	RegisterUnityClass<PlayableDirector>("Director");
	//71. ParticleSystem
	RegisterUnityClass<ParticleSystem>("ParticleSystem");
	//72. ParticleSystemRenderer
	RegisterUnityClass<ParticleSystemRenderer>("ParticleSystem");
	//73. SurfaceEffector2D
	RegisterUnityClass<SurfaceEffector2D>("Physics2D");
	//74. Effector2D
	RegisterUnityClass<Effector2D>("Physics2D");
	//75. FixedJoint2D
	RegisterUnityClass<FixedJoint2D>("Physics2D");
	//76. CapsuleCollider
	RegisterUnityClass<CapsuleCollider>("Physics");
	//77. AvatarMask
	RegisterUnityClass<AvatarMask>("Animation");
	//78. MonoScript
	RegisterUnityClass<MonoScript>("Core");
	//79. UnityConnectSettings
	RegisterUnityClass<UnityConnectSettings>("UnityConnect");
	//80. AudioManager
	RegisterUnityClass<AudioManager>("Audio");
	//81. PlayerSettings
	RegisterUnityClass<PlayerSettings>("Core");
	//82. PhysicsManager
	RegisterUnityClass<PhysicsManager>("Physics");
	//83. TimeManager
	RegisterUnityClass<TimeManager>("Core");
	//84. TagManager
	RegisterUnityClass<TagManager>("Core");
	//85. MonoManager
	RegisterUnityClass<MonoManager>("Core");
	//86. DelayedCallManager
	RegisterUnityClass<DelayedCallManager>("Core");
	//87. BuildSettings
	RegisterUnityClass<BuildSettings>("Core");
	//88. RuntimeInitializeOnLoadManager
	RegisterUnityClass<RuntimeInitializeOnLoadManager>("Core");
	//89. ResourceManager
	RegisterUnityClass<ResourceManager>("Core");
	//90. ScriptMapper
	RegisterUnityClass<ScriptMapper>("Core");
	//91. Physics2DSettings
	RegisterUnityClass<Physics2DSettings>("Physics2D");
	//92. AudioListener
	RegisterUnityClass<AudioListener>("Audio");
	//93. BoxCollider2D
	RegisterUnityClass<BoxCollider2D>("Physics2D");
	//94. SpringJoint2D
	RegisterUnityClass<SpringJoint2D>("Physics2D");
	//95. LightmapSettings
	RegisterUnityClass<LightmapSettings>("Core");
	//96. CGProgram
	RegisterUnityClass<CGProgram>("Core");
	//97. Grid
	RegisterUnityClass<Grid>("Grid");
	//98. GridLayout
	RegisterUnityClass<GridLayout>("Grid");
	//99. CircleCollider2D
	RegisterUnityClass<CircleCollider2D>("Physics2D");
	//100. CapsuleCollider2D
	RegisterUnityClass<CapsuleCollider2D>("Physics2D");
	//101. Tilemap
	RegisterUnityClass<Tilemap>("Tilemap");
	//102. TilemapRenderer
	RegisterUnityClass<TilemapRenderer>("Tilemap");
	//103. PhysicsMaterial2D
	RegisterUnityClass<PhysicsMaterial2D>("Physics2D");

}
