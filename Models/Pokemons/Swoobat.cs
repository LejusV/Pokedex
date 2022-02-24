using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Swoobat Specie to store common natural stats of every {'abilities': ['unaware', 'klutz', 'simple'], 'base_experience': 149, 'height': 9, 'id': 528, 'moves': ['gust', 'fly', 'hyper-beam', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'double-team', 'light-screen', 'reflect', 'amnesia', 'dream-eater', 'sky-attack', 'flash', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'protect', 'giga-drain', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'future-sight', 'uproar', 'heat-wave', 'torment', 'facade', 'taunt', 'helping-hand', 'trick', 'magic-coat', 'knock-off', 'endeavor', 'skill-swap', 'imprison', 'secret-power', 'air-cutter', 'odor-sleuth', 'signal-beam', 'aerial-ace', 'calm-mind', 'shock-wave', 'roost', 'gyro-ball', 'pluck', 'tailwind', 'u-turn', 'assurance', 'embargo', 'air-slash', 'energy-ball', 'giga-impact', 'zen-headbutt', 'trick-room', 'charge-beam', 'psyshock', 'telekinesis', 'after-you', 'round', 'acrobatics', 'heart-stamp', 'confide'], 'name': 'swoobat', 'stats': {'hp': 67, 'attack': 57, 'defense': 55, 'special-attack': 77, 'special-defense': 55, 'speed': 114}, 'types': ['psychic', 'flying'], 'weight': 105, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'wings', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['flying', 'ground'], 'names': {'ja-Hrkt': 'ココロモリ', 'ko': '맘박쥐', 'zh-Hant': '心蝙蝠', 'fr': 'Rhinolove', 'de': 'Fletiamo', 'es': 'Swoobat', 'it': 'Swoobat', 'en': 'Swoobat', 'ja': 'ココロモリ', 'zh-Hans': '心蝙蝠'}, 'genera': {'ja-Hrkt': 'きゅうあいポケモン', 'ko': '구애포켓몬', 'zh-Hant': '求愛寶可夢', 'fr': 'Pokémon Cupidon', 'de': 'Balz', 'es': 'Pokémon Galante', 'it': 'Pokémon Cercamore', 'en': 'Courting Pokémon', 'ja': 'きゅうあいポケモン', 'zh-Hans': '求爱宝可梦'}}
	public class SpecieSwoobat : PokemonSpecie
	{
#nullable enable
		private static SpecieSwoobat? _instance = null;
#nullable restore
        public static SpecieSwoobat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwoobat();
                }
                return _instance;
            }
        }

		public SpecieSwoobat() : base(
			"Swoobat",
			67, // HPs
			57, 55, // Attack & Defense
			77, 55, // Special Attack & Defense
			114			
		) {}
	}


	//Swoobat Pokemon Class
	public class Swoobat : Pokemon
	{

		public Swoobat(string nickname, int level)
		: base(
				528,
				SpecieSwoobat.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Swoobat(int level)
		: base(
				528,
				SpecieSwoobat.Instance, // Pokemon Specie
				"Swoobat", level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Swoobat() : base(
			528,
			SpecieSwoobat.Instance, // Pokemon Specie
			Psychic.Instance, Flying.Instance			
		) {}
	}
}