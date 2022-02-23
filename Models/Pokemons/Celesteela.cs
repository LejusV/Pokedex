using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Celesteela Specie to store common natural stats of every {'abilities': ['beast-boost'], 'base_experience': 257, 'height': 92, 'id': 797, 'moves': ['fly', 'tackle', 'double-edge', 'flamethrower', 'hyper-beam', 'absorb', 'mega-drain', 'leech-seed', 'solar-beam', 'earthquake', 'toxic', 'double-team', 'harden', 'fire-blast', 'skull-bash', 'explosion', 'rest', 'rock-slide', 'substitute', 'protect', 'giga-drain', 'swagger', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'facade', 'ingrain', 'metal-sound', 'iron-defense', 'gyro-ball', 'seed-bomb', 'air-slash', 'energy-ball', 'giga-impact', 'flash-cannon', 'iron-head', 'stone-edge', 'grass-knot', 'wide-guard', 'autotomize', 'smack-down', 'heavy-slam', 'flame-charge', 'round', 'acrobatics', 'bulldoze', 'confide', 'smart-strike', 'brutal-swing'], 'name': 'celesteela', 'stats': {'hp': 97, 'attack': 101, 'defense': 103, 'special-attack': 107, 'special-defense': 101, 'speed': 61}, 'types': ['steel', 'flying'], 'weight': 9999, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'green', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'テッカグヤ', 'ko': '철화구야', 'zh-Hant': '鐵火輝夜', 'fr': 'Bamboiselle', 'de': 'Kaguron', 'es': 'Celesteela', 'it': 'Celesteela', 'en': 'Celesteela', 'ja': 'テッカグヤ', 'zh-Hans': '铁火辉夜'}, 'genera': {'ja-Hrkt': 'うちあげポケモン', 'ko': '쏴올리기포켓몬', 'zh-Hant': '發射寶可夢', 'fr': 'Pokémon Décollage', 'de': 'Raketenstart', 'es': 'Pokémon Lanzamiento', 'it': 'Pokémon Decollo', 'en': 'Launch Pokémon', 'ja': 'うちあげポケモン', 'zh-Hans': '发射宝可梦'}}
	public class SpecieCelesteela : PokemonSpecie
	{
#nullable enable
		private static SpecieCelesteela? _instance = null;
#nullable restore
        public static SpecieCelesteela Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCelesteela();
                }
                return _instance;
            }
        }

		public SpecieCelesteela() : base(
			"Celesteela",
			97, // HPs
			101, 103, // Attack & Defense
			107, 101, // Special Attack & Defense
			61			
		) {}
	}


	//Celesteela Pokemon Class
	public class Celesteela : Pokemon
	{

		public Celesteela(string nickname, int level) : base(
			797,
			SpecieCelesteela.Instance, // Pokemon Specie
			nickname, level,
			Steel.Instance, Flying.Instance			
		) {}

		public Celesteela() : base(
			797,
			SpecieCelesteela.Instance, // Pokemon Specie
			Steel.Instance, Flying.Instance			
		) {}
	}
}