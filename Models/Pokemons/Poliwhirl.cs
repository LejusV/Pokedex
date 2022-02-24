using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Poliwhirl Specie to store common natural stats of every {'abilities': ['water-absorb', 'damp', 'swift-swim'], 'base_experience': 135, 'height': 10, 'id': 61, 'moves': ['double-slap', 'mega-punch', 'ice-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'earthquake', 'fissure', 'dig', 'toxic', 'psychic', 'hypnosis', 'rage', 'mimic', 'double-team', 'defense-curl', 'bide', 'metronome', 'waterfall', 'skull-bash', 'amnesia', 'bubble', 'psywave', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'belly-drum', 'mud-slap', 'icy-wind', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'rock-smash', 'whirlpool', 'hail', 'facade', 'focus-punch', 'helping-hand', 'brick-break', 'endeavor', 'secret-power', 'dive', 'mud-shot', 'water-sport', 'water-pulse', 'wake-up-slap', 'natural-gift', 'fling', 'mud-bomb', 'captivate', 'round', 'scald', 'bulldoze', 'confide', 'power-up-punch'], 'name': 'poliwhirl', 'stats': {'hp': 65, 'attack': 65, 'defense': 65, 'special-attack': 50, 'special-defense': 50, 'speed': 90}, 'types': ['water'], 'weight': 200, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'blue', 'shape': 'humanoid', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['water1'], 'names': {'ja-Hrkt': 'ニョロゾ', 'roomaji': 'Nyorozo', 'ko': '슈륙챙이', 'zh-Hant': '蚊香君', 'fr': 'Têtarte', 'de': 'Quaputzi', 'es': 'Poliwhirl', 'it': 'Poliwhirl', 'en': 'Poliwhirl', 'ja': 'ニョロゾ', 'zh-Hans': '蚊香君'}, 'genera': {'ja-Hrkt': 'おたまポケモン', 'ko': '올챙이포켓몬', 'zh-Hant': '蝌蚪寶可夢', 'fr': 'Pokémon Têtard', 'de': 'Kaulquappe', 'es': 'Pokémon Renacuajo', 'it': 'Pokémon Girino', 'en': 'Tadpole Pokémon', 'ja': 'おたまポケモン', 'zh-Hans': '蝌蚪宝可梦'}}
	public class SpeciePoliwhirl : PokemonSpecie
	{
#nullable enable
		private static SpeciePoliwhirl? _instance = null;
#nullable restore
        public static SpeciePoliwhirl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePoliwhirl();
                }
                return _instance;
            }
        }

		public SpeciePoliwhirl() : base(
			"Poliwhirl",
			65, // HPs
			65, 65, // Attack & Defense
			50, 50, // Special Attack & Defense
			90			
		) {}
	}


	//Poliwhirl Pokemon Class
	public class Poliwhirl : Pokemon
	{

		public Poliwhirl(string nickname, int level)
		: base(
				61,
				SpeciePoliwhirl.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Poliwhirl(int level)
		: base(
				61,
				SpeciePoliwhirl.Instance, // Pokemon Specie
				"Poliwhirl", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Poliwhirl() : base(
			61,
			SpeciePoliwhirl.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}