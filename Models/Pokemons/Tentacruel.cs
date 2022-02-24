using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tentacruel Specie to store common natural stats of every {'abilities': ['clear-body', 'liquid-ooze', 'rain-dish'], 'base_experience': 180, 'height': 16, 'id': 73, 'moves': ['swords-dance', 'cut', 'bind', 'wrap', 'take-down', 'double-edge', 'poison-sting', 'supersonic', 'acid', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'mega-drain', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'barrier', 'reflect', 'bide', 'waterfall', 'skull-bash', 'constrict', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'icy-wind', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'whirlpool', 'hail', 'facade', 'magic-coat', 'knock-off', 'secret-power', 'dive', 'water-pulse', 'brine', 'natural-gift', 'payback', 'wring-out', 'toxic-spikes', 'poison-jab', 'giga-impact', 'captivate', 'venoshock', 'sludge-wave', 'acid-spray', 'round', 'scald', 'hex', 'reflect-type', 'confide', 'dazzling-gleam', 'infestation'], 'name': 'tentacruel', 'stats': {'hp': 80, 'attack': 70, 'defense': 65, 'special-attack': 80, 'special-defense': 120, 'speed': 100}, 'types': ['water', 'poison'], 'weight': 550, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'blue', 'shape': 'tentacles', 'habitat': 'sea', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['water3'], 'names': {'ja-Hrkt': 'ドククラゲ', 'roomaji': 'Dokukurage', 'ko': '독파리', 'zh-Hant': '毒刺水母', 'fr': 'Tentacruel', 'de': 'Tentoxa', 'es': 'Tentacruel', 'it': 'Tentacruel', 'en': 'Tentacruel', 'ja': 'ドククラゲ', 'zh-Hans': '毒刺水母'}, 'genera': {'ja-Hrkt': 'くらげポケモン', 'ko': '해파리포켓몬', 'zh-Hant': '水母寶可夢', 'fr': 'Pokémon Mollusque', 'de': 'Qualle', 'es': 'Pokémon Medusa', 'it': 'Pokémon Medusa', 'en': 'Jellyfish Pokémon', 'ja': 'くらげポケモン', 'zh-Hans': '水母宝可梦'}}
	public class SpecieTentacruel : PokemonSpecie
	{
#nullable enable
		private static SpecieTentacruel? _instance = null;
#nullable restore
        public static SpecieTentacruel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTentacruel();
                }
                return _instance;
            }
        }

		public SpecieTentacruel() : base(
			"Tentacruel",
			80, // HPs
			70, 65, // Attack & Defense
			80, 120, // Special Attack & Defense
			100			
		) {}
	}


	//Tentacruel Pokemon Class
	public class Tentacruel : Pokemon
	{

		public Tentacruel(string nickname, int level)
		: base(
				73,
				SpecieTentacruel.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tentacruel() : base(
			73,
			SpecieTentacruel.Instance, // Pokemon Specie
			Water.Instance, Poison.Instance			
		) {}
	}
}