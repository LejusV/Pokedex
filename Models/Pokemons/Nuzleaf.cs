using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Nuzleaf Specie to store common natural stats of every {'abilities': ['chlorophyll', 'early-bird', 'pickpocket'], 'base_experience': 119, 'height': 10, 'id': 274, 'moves': ['pound', 'razor-wind', 'swords-dance', 'cut', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'hyper-beam', 'low-kick', 'strength', 'growth', 'razor-leaf', 'solar-beam', 'dig', 'toxic', 'mimic', 'double-team', 'harden', 'defense-curl', 'self-destruct', 'swift', 'flash', 'explosion', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'spite', 'protect', 'feint-attack', 'mud-slap', 'giga-drain', 'endure', 'rollout', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'synthesis', 'hidden-power', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'fake-out', 'torment', 'facade', 'nature-power', 'brick-break', 'secret-power', 'rock-tomb', 'extrasensory', 'bullet-seed', 'leaf-blade', 'natural-gift', 'payback', 'embargo', 'fling', 'worry-seed', 'dark-pulse', 'seed-bomb', 'energy-ball', 'captivate', 'grass-knot', 'low-sweep', 'foul-play', 'round', 'retaliate', 'snarl', 'confide', 'power-up-punch'], 'name': 'nuzleaf', 'stats': {'hp': 70, 'attack': 70, 'defense': 40, 'special-attack': 60, 'special-defense': 40, 'speed': 60}, 'types': ['grass', 'dark'], 'weight': 280, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'brown', 'shape': 'humanoid', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['ground', 'plant'], 'names': {'ja-Hrkt': 'コノハナ', 'roomaji': 'Konohana', 'ko': '잎새코', 'zh-Hant': '長鼻葉', 'fr': 'Pifeuil', 'de': 'Blanas', 'es': 'Nuzleaf', 'it': 'Nuzleaf', 'en': 'Nuzleaf', 'ja': 'コノハナ', 'zh-Hans': '长鼻叶'}, 'genera': {'ja-Hrkt': 'いじわるポケモン', 'ko': '꾀부리기포켓몬', 'zh-Hant': '捉弄寶可夢', 'fr': 'Pokémon Malin', 'de': 'Hinterlist', 'es': 'Pokémon Astuto', 'it': 'Pokémon Scaltro', 'en': 'Wily Pokémon', 'ja': 'いじわるポケモン', 'zh-Hans': '捉弄宝可梦'}}
	public class SpecieNuzleaf : PokemonSpecie
	{
#nullable enable
		private static SpecieNuzleaf? _instance = null;
#nullable restore
        public static SpecieNuzleaf Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNuzleaf();
                }
                return _instance;
            }
        }

		public SpecieNuzleaf() : base(
			"Nuzleaf",
			70, // HPs
			70, 40, // Attack & Defense
			60, 40, // Special Attack & Defense
			60			
		) {}
	}


	//Nuzleaf Pokemon Class
	public class Nuzleaf : Pokemon
	{

		public Nuzleaf(string nickname, int level) : base(
			274,
			SpecieNuzleaf.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Dark.Instance			
		) {}

		public Nuzleaf() : base(
			274,
			SpecieNuzleaf.Instance, // Pokemon Specie
			Grass.Instance, Dark.Instance			
		) {}
	}
}