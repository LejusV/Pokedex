using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Scyther Specie to store common natural stats of every {'abilities': ['swarm', 'technician', 'steadfast'], 'base_experience': 100, 'height': 15, 'id': 123, 'moves': ['razor-wind', 'swords-dance', 'cut', 'wing-attack', 'headbutt', 'take-down', 'double-edge', 'leer', 'hyper-beam', 'counter', 'toxic', 'agility', 'quick-attack', 'rage', 'mimic', 'double-team', 'light-screen', 'focus-energy', 'bide', 'swift', 'skull-bash', 'rest', 'slash', 'substitute', 'thief', 'snore', 'curse', 'reversal', 'protect', 'detect', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'baton-pass', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'brick-break', 'knock-off', 'secret-power', 'silver-wind', 'aerial-ace', 'roost', 'natural-gift', 'feint', 'tailwind', 'u-turn', 'night-slash', 'air-slash', 'x-scissor', 'bug-buzz', 'vacuum-wave', 'giga-impact', 'defog', 'captivate', 'bug-bite', 'double-hit', 'ominous-wind', 'round', 'quick-guard', 'struggle-bug', 'confide', 'brutal-swing'], 'name': 'scyther', 'stats': {'hp': 70, 'attack': 110, 'defense': 80, 'special-attack': 55, 'special-defense': 80, 'speed': 105}, 'types': ['bug', 'flying'], 'weight': 560, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 45, 'color': 'green', 'shape': 'bug-wings', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ストライク', 'roomaji': 'Strike', 'ko': '스라크', 'zh-Hant': '飛天螳螂', 'fr': 'Insécateur', 'de': 'Sichlor', 'es': 'Scyther', 'it': 'Scyther', 'en': 'Scyther', 'ja': 'ストライク', 'zh-Hans': '飞天螳螂'}, 'genera': {'ja-Hrkt': 'かまきりポケモン', 'ko': '버마재비포켓몬', 'zh-Hant': '螳螂寶可夢', 'fr': 'Pokémon Mante', 'de': 'Mantis', 'es': 'Pokémon Mantis', 'it': 'Pokémon Mantide', 'en': 'Mantis Pokémon', 'ja': 'かまきりポケモン', 'zh-Hans': '螳螂宝可梦'}}
	public class SpecieScyther : PokemonSpecie
	{
#nullable enable
		private static SpecieScyther? _instance = null;
#nullable restore
        public static SpecieScyther Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieScyther();
                }
                return _instance;
            }
        }

		public SpecieScyther() : base(
			"Scyther",
			70, // HPs
			110, 80, // Attack & Defense
			55, 80, // Special Attack & Defense
			105			
		) {}
	}


	//Scyther Pokemon Class
	public class Scyther : Pokemon
	{

		public Scyther(string nickname, int level) : base(
			123,
			SpecieScyther.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance, Flying.Instance			
		) {}

		public Scyther() : base(
			123,
			SpecieScyther.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
	}
}