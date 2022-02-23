using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lapras Specie to store common natural stats of every {'abilities': ['water-absorb', 'shell-armor', 'hydration'], 'base_experience': 187, 'height': 25, 'id': 131, 'moves': ['headbutt', 'horn-drill', 'body-slam', 'take-down', 'double-edge', 'growl', 'roar', 'sing', 'mist', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'aurora-beam', 'hyper-beam', 'strength', 'solar-beam', 'dragon-rage', 'thunderbolt', 'thunder', 'fissure', 'toxic', 'psychic', 'rage', 'mimic', 'double-team', 'confuse-ray', 'reflect', 'bide', 'waterfall', 'skull-bash', 'dream-eater', 'psywave', 'rest', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'zap-cannon', 'foresight', 'perish-song', 'icy-wind', 'outrage', 'endure', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'dragon-breath', 'iron-tail', 'hidden-power', 'rain-dance', 'ancient-power', 'future-sight', 'rock-smash', 'whirlpool', 'hail', 'facade', 'refresh', 'secret-power', 'dive', 'hyper-voice', 'tickle', 'signal-beam', 'sheer-cold', 'block', 'dragon-dance', 'shock-wave', 'water-pulse', 'brine', 'natural-gift', 'aqua-tail', 'dragon-pulse', 'giga-impact', 'avalanche', 'ice-shard', 'zen-headbutt', 'iron-head', 'captivate', 'round', 'echoed-voice', 'bulldoze', 'frost-breath', 'drill-run', 'freeze-dry', 'confide', 'smart-strike'], 'name': 'lapras', 'stats': {'hp': 130, 'attack': 85, 'defense': 80, 'special-attack': 85, 'special-defense': 95, 'speed': 60}, 'types': ['water', 'ice'], 'weight': 2200, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'fish', 'habitat': 'sea', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['monster', 'water1'], 'names': {'ja-Hrkt': 'ラプラス', 'roomaji': 'Laplace', 'ko': '라프라스', 'zh-Hant': '拉普拉斯', 'fr': 'Lokhlass', 'de': 'Lapras', 'es': 'Lapras', 'it': 'Lapras', 'en': 'Lapras', 'ja': 'ラプラス', 'zh-Hans': '拉普拉斯'}, 'genera': {'ja-Hrkt': 'のりものポケモン', 'ko': '탈것포켓몬', 'zh-Hant': '乘載寶可夢', 'fr': 'Pokémon Transport', 'de': 'Transport', 'es': 'Pokémon Transporte', 'it': 'Pokémon Trasporto', 'en': 'Transport Pokémon', 'ja': 'のりものポケモン', 'zh-Hans': '乘载宝可梦'}}
	public class SpecieLapras : PokemonSpecie
	{
#nullable enable
		private static SpecieLapras? _instance = null;
#nullable restore
        public static SpecieLapras Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLapras();
                }
                return _instance;
            }
        }

		public SpecieLapras() : base(
			"Lapras",
			130, // HPs
			85, 80, // Attack & Defense
			85, 95, // Special Attack & Defense
			60			
		) {}
	}


	//Lapras Pokemon Class
	public class Lapras : Pokemon
	{

		public Lapras(string nickname, int level) : base(
			131,
			SpecieLapras.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Ice.Instance			
		) {}

		public Lapras() : base(
			131,
			SpecieLapras.Instance, // Pokemon Specie
			Water.Instance, Ice.Instance			
		) {}
	}
}