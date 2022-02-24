using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Omastar Specie to store common natural stats of every {'abilities': ['swift-swim', 'shell-armor', 'weak-armor'], 'base_experience': 173, 'height': 10, 'id': 139, 'moves': ['bind', 'headbutt', 'horn-attack', 'horn-drill', 'body-slam', 'take-down', 'double-edge', 'leer', 'bite', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'seismic-toss', 'toxic', 'rage', 'mimic', 'double-team', 'withdraw', 'reflect', 'bide', 'waterfall', 'skull-bash', 'spike-cannon', 'constrict', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'protect', 'icy-wind', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'ancient-power', 'rock-smash', 'whirlpool', 'hail', 'facade', 'knock-off', 'secret-power', 'dive', 'rock-tomb', 'tickle', 'iron-defense', 'mud-shot', 'rock-blast', 'water-pulse', 'gyro-ball', 'brine', 'natural-gift', 'rock-polish', 'earth-power', 'giga-impact', 'rock-climb', 'stone-edge', 'captivate', 'stealth-rock', 'smack-down', 'round', 'scald', 'shell-smash', 'confide'], 'name': 'omastar', 'stats': {'hp': 70, 'attack': 60, 'defense': 125, 'special-attack': 115, 'special-defense': 70, 'speed': 55}, 'types': ['rock', 'water'], 'weight': 350, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'tentacles', 'habitat': 'sea', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['water1', 'water3'], 'names': {'ja-Hrkt': 'オムスター', 'roomaji': 'Omstar', 'ko': '암스타', 'zh-Hant': '多刺菊石獸', 'fr': 'Amonistar', 'de': 'Amoroso', 'es': 'Omastar', 'it': 'Omastar', 'en': 'Omastar', 'ja': 'オムスター', 'zh-Hans': '多刺菊石兽'}, 'genera': {'ja-Hrkt': 'うずまきポケモン', 'ko': '소용돌이포켓몬', 'zh-Hant': '漩渦寶可夢', 'fr': 'Pokémon Spirale', 'de': 'Spirale', 'es': 'Pokémon Espiral', 'it': 'Pokémon Spirale', 'en': 'Spiral Pokémon', 'ja': 'うずまきポケモン', 'zh-Hans': '漩涡宝可梦'}}
	public class SpecieOmastar : PokemonSpecie
	{
#nullable enable
		private static SpecieOmastar? _instance = null;
#nullable restore
        public static SpecieOmastar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOmastar();
                }
                return _instance;
            }
        }

		public SpecieOmastar() : base(
			"Omastar",
			70, // HPs
			60, 125, // Attack & Defense
			115, 70, // Special Attack & Defense
			55			
		) {}
	}


	//Omastar Pokemon Class
	public class Omastar : Pokemon
	{

		public Omastar(string nickname, int level)
		: base(
				139,
				SpecieOmastar.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Omastar(int level)
		: base(
				139,
				SpecieOmastar.Instance, // Pokemon Specie
				"Omastar", level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Omastar() : base(
			139,
			SpecieOmastar.Instance, // Pokemon Specie
			Rock.Instance, Water.Instance			
		) {}
	}
}