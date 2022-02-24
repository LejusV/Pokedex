using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Forretress Specie to store common natural stats of every {'abilities': ['sturdy', 'overcoat'], 'base_experience': 163, 'height': 12, 'id': 205, 'moves': ['headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'hyper-beam', 'counter', 'strength', 'solar-beam', 'string-shot', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'bide', 'self-destruct', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'spikes', 'zap-cannon', 'sandstorm', 'giga-drain', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'rapid-spin', 'sweet-scent', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'secret-power', 'rock-tomb', 'signal-beam', 'iron-defense', 'block', 'gravity', 'gyro-ball', 'natural-gift', 'payback', 'toxic-spikes', 'magnet-rise', 'rock-polish', 'giga-impact', 'mirror-shot', 'flash-cannon', 'captivate', 'stealth-rock', 'bug-bite', 'venoshock', 'autotomize', 'heavy-slam', 'round', 'volt-switch', 'struggle-bug', 'bulldoze', 'drill-run', 'confide'], 'name': 'forretress', 'stats': {'hp': 75, 'attack': 90, 'defense': 140, 'special-attack': 60, 'special-defense': 60, 'speed': 40}, 'types': ['bug', 'steel'], 'weight': 1258, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'purple', 'shape': 'ball', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'フォレトス', 'roomaji': 'Foretos', 'ko': '쏘콘', 'zh-Hant': '佛烈托斯', 'fr': 'Foretress', 'de': 'Forstellka', 'es': 'Forretress', 'it': 'Forretress', 'en': 'Forretress', 'ja': 'フォレトス', 'zh-Hans': '佛烈托斯'}, 'genera': {'ja-Hrkt': 'みのむしポケモン', 'ko': '도롱이벌레포켓몬', 'zh-Hant': '蓑衣蟲寶可夢', 'fr': 'Pokémon Ver Caché', 'de': 'Beutelwurm', 'es': 'Pokémon Larva', 'it': 'Pokémon Larva', 'en': 'Bagworm Pokémon', 'ja': 'みのむしポケモン', 'zh-Hans': '蓑衣虫宝可梦'}}
	public class SpecieForretress : PokemonSpecie
	{
#nullable enable
		private static SpecieForretress? _instance = null;
#nullable restore
        public static SpecieForretress Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieForretress();
                }
                return _instance;
            }
        }

		public SpecieForretress() : base(
			"Forretress",
			75, // HPs
			90, 140, // Attack & Defense
			60, 60, // Special Attack & Defense
			40			
		) {}
	}


	//Forretress Pokemon Class
	public class Forretress : Pokemon
	{

		public Forretress(string nickname, int level)
		: base(
				205,
				SpecieForretress.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Forretress() : base(
			205,
			SpecieForretress.Instance, // Pokemon Specie
			Bug.Instance, Steel.Instance			
		) {}
	}
}