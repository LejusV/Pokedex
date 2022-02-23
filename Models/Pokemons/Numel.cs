using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Numel Specie to store common natural stats of every {'abilities': ['oblivious', 'simple', 'own-tempo'], 'base_experience': 61, 'height': 7, 'id': 322, 'moves': ['stomp', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'growl', 'ember', 'flamethrower', 'strength', 'growth', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'focus-energy', 'fire-blast', 'amnesia', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'scary-face', 'mud-slap', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'magnitude', 'hidden-power', 'sunny-day', 'ancient-power', 'rock-smash', 'stockpile', 'spit-up', 'swallow', 'heat-wave', 'will-o-wisp', 'facade', 'nature-power', 'yawn', 'secret-power', 'overheat', 'rock-tomb', 'howl', 'natural-gift', 'earth-power', 'mud-bomb', 'lava-plume', 'iron-head', 'captivate', 'stealth-rock', 'flame-burst', 'heavy-slam', 'flame-charge', 'after-you', 'round', 'echoed-voice', 'incinerate', 'bulldoze', 'confide'], 'name': 'numel', 'stats': {'hp': 60, 'attack': 60, 'defense': 40, 'special-attack': 65, 'special-defense': 45, 'speed': 35}, 'types': ['fire', 'ground'], 'weight': 240, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'yellow', 'shape': 'quadruped', 'habitat': 'mountain', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ドンメル', 'roomaji': 'Donmel', 'ko': '둔타', 'zh-Hant': '呆火駝', 'fr': 'Chamallot', 'de': 'Camaub', 'es': 'Numel', 'it': 'Numel', 'en': 'Numel', 'ja': 'ドンメル', 'zh-Hans': '呆火驼'}, 'genera': {'ja-Hrkt': 'どんかんポケモン', 'ko': '둔감포켓몬', 'zh-Hant': '遲鈍寶可夢', 'fr': 'Pokémon Engourdi', 'de': 'Taubheit', 'es': 'Pokémon Torpe', 'it': 'Pokémon Torpore', 'en': 'Numb Pokémon', 'ja': 'どんかんポケモン', 'zh-Hans': '迟钝宝可梦'}}
	public class SpecieNumel : PokemonSpecie
	{
#nullable enable
		private static SpecieNumel? _instance = null;
#nullable restore
        public static SpecieNumel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNumel();
                }
                return _instance;
            }
        }

		public SpecieNumel() : base(
			"Numel",
			60, // HPs
			60, 40, // Attack & Defense
			65, 45, // Special Attack & Defense
			35			
		) {}
	}


	//Numel Pokemon Class
	public class Numel : Pokemon
	{

		public Numel(string nickname, int level) : base(
			322,
			SpecieNumel.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance, Ground.Instance			
		) {}

		public Numel() : base(
			322,
			SpecieNumel.Instance, // Pokemon Specie
			Fire.Instance, Ground.Instance			
		) {}
	}
}