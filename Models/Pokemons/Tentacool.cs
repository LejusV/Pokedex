using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tentacool Specie to store common natural stats of every {'abilities': ['clear-body', 'liquid-ooze', 'rain-dish'], 'base_experience': 67, 'height': 9, 'id': 72, 'moves': ['swords-dance', 'cut', 'bind', 'wrap', 'take-down', 'double-edge', 'poison-sting', 'supersonic', 'acid', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'aurora-beam', 'mega-drain', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'confuse-ray', 'barrier', 'haze', 'reflect', 'bide', 'waterfall', 'skull-bash', 'constrict', 'bubble', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'icy-wind', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'rapid-spin', 'hidden-power', 'rain-dance', 'mirror-coat', 'whirlpool', 'hail', 'facade', 'magic-coat', 'knock-off', 'secret-power', 'dive', 'tickle', 'muddy-water', 'water-pulse', 'brine', 'natural-gift', 'acupressure', 'payback', 'wring-out', 'toxic-spikes', 'aqua-ring', 'poison-jab', 'captivate', 'venoshock', 'sludge-wave', 'acid-spray', 'round', 'scald', 'hex', 'confide', 'dazzling-gleam', 'infestation'], 'name': 'tentacool', 'stats': {'hp': 40, 'attack': 40, 'defense': 35, 'special-attack': 50, 'special-defense': 100, 'speed': 70}, 'types': ['water', 'poison'], 'weight': 455, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'blue', 'shape': 'tentacles', 'habitat': 'sea', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['water3'], 'names': {'ja-Hrkt': 'メノクラゲ', 'roomaji': 'Menokurage', 'ko': '왕눈해', 'zh-Hant': '瑪瑙水母', 'fr': 'Tentacool', 'de': 'Tentacha', 'es': 'Tentacool', 'it': 'Tentacool', 'en': 'Tentacool', 'ja': 'メノクラゲ', 'zh-Hans': '玛瑙水母'}, 'genera': {'ja-Hrkt': 'くらげポケモン', 'ko': '해파리포켓몬', 'zh-Hant': '水母寶可夢', 'fr': 'Pokémon Mollusque', 'de': 'Qualle', 'es': 'Pokémon Medusa', 'it': 'Pokémon Medusa', 'en': 'Jellyfish Pokémon', 'ja': 'くらげポケモン', 'zh-Hans': '水母宝可梦'}}
	public class SpecieTentacool : PokemonSpecie
	{
#nullable enable
		private static SpecieTentacool? _instance = null;
#nullable restore
        public static SpecieTentacool Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTentacool();
                }
                return _instance;
            }
        }

		public SpecieTentacool() : base(
			"Tentacool",
			40, // HPs
			40, 35, // Attack & Defense
			50, 100, // Special Attack & Defense
			70			
		) {}
	}


	//Tentacool Pokemon Class
	public class Tentacool : Pokemon
	{

		public Tentacool(string nickname, int level)
		: base(
				72,
				SpecieTentacool.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tentacool(int level)
		: base(
				72,
				SpecieTentacool.Instance, // Pokemon Specie
				"Tentacool", level,
				Water.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tentacool() : base(
			72,
			SpecieTentacool.Instance, // Pokemon Specie
			Water.Instance, Poison.Instance			
		) {}
	}
}