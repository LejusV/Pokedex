using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Camerupt Specie to store common natural stats of every {'abilities': ['magma-armor', 'solid-rock', 'anger-point'], 'base_experience': 161, 'height': 19, 'id': 323, 'moves': ['headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'growl', 'roar', 'ember', 'flamethrower', 'hyper-beam', 'strength', 'solar-beam', 'earthquake', 'fissure', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'focus-energy', 'self-destruct', 'fire-blast', 'amnesia', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'magnitude', 'hidden-power', 'sunny-day', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'nature-power', 'yawn', 'eruption', 'secret-power', 'overheat', 'rock-tomb', 'natural-gift', 'rock-polish', 'earth-power', 'giga-impact', 'flash-cannon', 'lava-plume', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'flame-burst', 'flame-charge', 'after-you', 'round', 'echoed-voice', 'incinerate', 'bulldoze', 'confide'], 'name': 'camerupt', 'stats': {'hp': 70, 'attack': 100, 'defense': 70, 'special-attack': 105, 'special-defense': 75, 'speed': 40}, 'types': ['fire', 'ground'], 'weight': 2200, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 150, 'color': 'red', 'shape': 'quadruped', 'habitat': 'mountain', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'バクーダ', 'roomaji': 'Bakuuda', 'ko': '폭타', 'zh-Hant': '噴火駝', 'fr': 'Camérupt', 'de': 'Camerupt', 'es': 'Camerupt', 'it': 'Camerupt', 'en': 'Camerupt', 'ja': 'バクーダ', 'zh-Hans': '喷火驼'}, 'genera': {'ja-Hrkt': 'ふんかポケモン', 'ko': '분화포켓몬', 'zh-Hant': '噴火寶可夢', 'fr': 'Pokémon Éruption', 'de': 'Ausbruch', 'es': 'Pokémon Erupción', 'it': 'Pokémon Eruzione', 'en': 'Eruption Pokémon', 'ja': 'ふんかポケモン', 'zh-Hans': '喷火宝可梦'}}
	public class SpecieCamerupt : PokemonSpecie
	{
#nullable enable
		private static SpecieCamerupt? _instance = null;
#nullable restore
        public static SpecieCamerupt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCamerupt();
                }
                return _instance;
            }
        }

		public SpecieCamerupt() : base(
			"Camerupt",
			70, // HPs
			100, 70, // Attack & Defense
			105, 75, // Special Attack & Defense
			40			
		) {}
	}


	//Camerupt Pokemon Class
	public class Camerupt : Pokemon
	{

		public Camerupt(string nickname, int level)
		: base(
				323,
				SpecieCamerupt.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Camerupt(int level)
		: base(
				323,
				SpecieCamerupt.Instance, // Pokemon Specie
				"Camerupt", level,
				Fire.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Camerupt() : base(
			323,
			SpecieCamerupt.Instance, // Pokemon Specie
			Fire.Instance, Ground.Instance			
		) {}
	}
}