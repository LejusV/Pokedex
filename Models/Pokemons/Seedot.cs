using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Seedot Specie to store common natural stats of every {'abilities': ['chlorophyll', 'early-bird', 'pickpocket'], 'base_experience': 44, 'height': 5, 'id': 273, 'moves': ['razor-wind', 'swords-dance', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'leech-seed', 'growth', 'solar-beam', 'dig', 'toxic', 'quick-attack', 'mimic', 'double-team', 'harden', 'defense-curl', 'bide', 'self-destruct', 'amnesia', 'flash', 'explosion', 'rest', 'substitute', 'snore', 'spite', 'protect', 'giga-drain', 'endure', 'rollout', 'false-swipe', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'synthesis', 'hidden-power', 'sunny-day', 'shadow-ball', 'rock-smash', 'beat-up', 'facade', 'nature-power', 'secret-power', 'bullet-seed', 'natural-gift', 'power-swap', 'worry-seed', 'seed-bomb', 'energy-ball', 'nasty-plot', 'defog', 'captivate', 'grass-knot', 'foul-play', 'round', 'retaliate', 'grassy-terrain', 'confide'], 'name': 'seedot', 'stats': {'hp': 40, 'attack': 40, 'defense': 50, 'special-attack': 30, 'special-defense': 30, 'speed': 30}, 'types': ['grass'], 'weight': 40, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'legs', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['ground', 'plant'], 'names': {'ja-Hrkt': 'タネボー', 'roomaji': 'Taneboh', 'ko': '도토링', 'zh-Hant': '橡實果', 'fr': 'Grainipiot', 'de': 'Samurzel', 'es': 'Seedot', 'it': 'Seedot', 'en': 'Seedot', 'ja': 'タネボー', 'zh-Hans': '橡实果'}, 'genera': {'ja-Hrkt': 'どんぐりポケモン', 'ko': '도토리포켓몬', 'zh-Hant': '橡實寶可夢', 'fr': 'Pokémon Gland', 'de': 'Eichelnuss', 'es': 'Pokémon Bellota', 'it': 'Pokémon Ghianda', 'en': 'Acorn Pokémon', 'ja': 'どんぐりポケモン', 'zh-Hans': '橡实宝可梦'}}
	public class SpecieSeedot : PokemonSpecie
	{
#nullable enable
		private static SpecieSeedot? _instance = null;
#nullable restore
        public static SpecieSeedot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSeedot();
                }
                return _instance;
            }
        }

		public SpecieSeedot() : base(
			"Seedot",
			40, // HPs
			40, 50, // Attack & Defense
			30, 30, // Special Attack & Defense
			30			
		) {}
	}


	//Seedot Pokemon Class
	public class Seedot : Pokemon
	{

		public Seedot(string nickname, int level)
		: base(
				273,
				SpecieSeedot.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Seedot() : base(
			273,
			SpecieSeedot.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}