using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Illumise Specie to store common natural stats of every {'abilities': ['oblivious', 'tinted-lens', 'prankster'], 'base_experience': 151, 'height': 6, 'id': 314, 'moves': ['mega-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'tackle', 'body-slam', 'double-edge', 'counter', 'seismic-toss', 'growth', 'solar-beam', 'string-shot', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'quick-attack', 'mimic', 'double-team', 'confuse-ray', 'light-screen', 'metronome', 'swift', 'flash', 'rest', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'giga-drain', 'endure', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'baton-pass', 'encore', 'sweet-scent', 'moonlight', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'flatter', 'facade', 'focus-punch', 'helping-hand', 'wish', 'brick-break', 'secret-power', 'aromatherapy', 'fake-tears', 'air-cutter', 'silver-wind', 'aerial-ace', 'covet', 'shock-wave', 'water-pulse', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'fling', 'bug-buzz', 'zen-headbutt', 'captivate', 'bug-bite', 'charge-beam', 'ominous-wind', 'round', 'acrobatics', 'struggle-bug', 'play-rough', 'play-nice', 'confide', 'dazzling-gleam', 'infestation', 'power-up-punch'], 'name': 'illumise', 'stats': {'hp': 65, 'attack': 47, 'defense': 75, 'special-attack': 73, 'special-defense': 85, 'speed': 85}, 'types': ['bug'], 'weight': 177, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 8, 'capture_rate': 150, 'color': 'purple', 'shape': 'humanoid', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'fast-then-very-slow', 'egg_groups': ['bug', 'humanshape'], 'names': {'ja-Hrkt': 'イルミーゼ', 'roomaji': 'Illumise', 'ko': '네오비트', 'zh-Hant': '甜甜螢', 'fr': 'Lumivole', 'de': 'Illumise', 'es': 'Illumise', 'it': 'Illumise', 'en': 'Illumise', 'ja': 'イルミーゼ', 'zh-Hans': '甜甜萤'}, 'genera': {'ja-Hrkt': 'ほたるポケモン', 'ko': '반딧불포켓몬', 'zh-Hant': '螢火蟲寶可夢', 'fr': 'Pokémon Luciole', 'de': 'Glühwürmchen', 'es': 'Pokémon Luciérnaga', 'it': 'Pokémon Lucciola', 'en': 'Firefly Pokémon', 'ja': 'ほたるポケモン', 'zh-Hans': '萤火虫宝可梦'}}
	public class SpecieIllumise : PokemonSpecie
	{
#nullable enable
		private static SpecieIllumise? _instance = null;
#nullable restore
        public static SpecieIllumise Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieIllumise();
                }
                return _instance;
            }
        }

		public SpecieIllumise() : base(
			"Illumise",
			65, // HPs
			47, 75, // Attack & Defense
			73, 85, // Special Attack & Defense
			85			
		) {}
	}


	//Illumise Pokemon Class
	public class Illumise : Pokemon
	{

		public Illumise(string nickname, int level)
		: base(
				314,
				SpecieIllumise.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Illumise(int level)
		: base(
				314,
				SpecieIllumise.Instance, // Pokemon Specie
				"Illumise", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Illumise() : base(
			314,
			SpecieIllumise.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}