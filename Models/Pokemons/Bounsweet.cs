using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bounsweet Specie to store common natural stats of every {'abilities': ['leaf-guard', 'oblivious', 'sweet-veil'], 'base_experience': 42, 'height': 3, 'id': 761, 'moves': ['razor-leaf', 'solar-beam', 'toxic', 'double-team', 'light-screen', 'reflect', 'splash', 'rest', 'substitute', 'flail', 'protect', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'rapid-spin', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'teeter-dance', 'grass-whistle', 'magical-leaf', 'feint', 'acupressure', 'energy-ball', 'grass-knot', 'round', 'play-rough', 'play-nice', 'confide', 'aromatic-mist', 'dazzling-gleam'], 'name': 'bounsweet', 'stats': {'hp': 42, 'attack': 30, 'defense': 38, 'special-attack': 30, 'special-defense': 38, 'speed': 32}, 'types': ['grass'], 'weight': 32, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 235, 'color': 'purple', 'shape': 'legs', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium-slow', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'アマカジ', 'ko': '달콤아', 'zh-Hant': '甜竹竹', 'fr': 'Croquine', 'de': 'Frubberl', 'es': 'Bounsweet', 'it': 'Bounsweet', 'en': 'Bounsweet', 'ja': 'アマカジ', 'zh-Hans': '甜竹竹'}, 'genera': {'ja-Hrkt': 'フルーツポケモン', 'ko': '후르츠포켓몬', 'zh-Hant': '水果寶可夢', 'fr': 'Pokémon Fruit', 'de': 'Obst', 'es': 'Pokémon Fruto', 'it': 'Pokémon Frutto', 'en': 'Fruit Pokémon', 'ja': 'フルーツポケモン', 'zh-Hans': '水果宝可梦'}}
	public class SpecieBounsweet : PokemonSpecie
	{
#nullable enable
		private static SpecieBounsweet? _instance = null;
#nullable restore
        public static SpecieBounsweet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBounsweet();
                }
                return _instance;
            }
        }

		public SpecieBounsweet() : base(
			"Bounsweet",
			42, // HPs
			30, 38, // Attack & Defense
			30, 38, // Special Attack & Defense
			32			
		) {}
	}


	//Bounsweet Pokemon Class
	public class Bounsweet : Pokemon
	{

		public Bounsweet(string nickname, int level)
		: base(
				761,
				SpecieBounsweet.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bounsweet() : base(
			761,
			SpecieBounsweet.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}