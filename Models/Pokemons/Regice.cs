using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Regice Specie to store common natural stats of every {'abilities': ['clear-body', 'ice-body'], 'base_experience': 261, 'height': 18, 'id': 378, 'moves': ['mega-punch', 'ice-punch', 'thunder-punch', 'stomp', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'ice-beam', 'blizzard', 'hyper-beam', 'counter', 'seismic-toss', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'mimic', 'double-team', 'defense-curl', 'self-destruct', 'amnesia', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'icy-wind', 'lock-on', 'endure', 'rollout', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'hidden-power', 'rain-dance', 'psych-up', 'ancient-power', 'rock-smash', 'hail', 'facade', 'focus-punch', 'superpower', 'brick-break', 'secret-power', 'rock-tomb', 'signal-beam', 'block', 'shock-wave', 'gravity', 'hammer-arm', 'natural-gift', 'fling', 'rock-polish', 'focus-blast', 'giga-impact', 'avalanche', 'flash-cannon', 'rock-climb', 'iron-head', 'charge-beam', 'round', 'bulldoze', 'frost-breath', 'confide', 'power-up-punch', 'aurora-veil'], 'name': 'regice', 'stats': {'hp': 80, 'attack': 50, 'defense': 100, 'special-attack': 100, 'special-defense': 200, 'speed': 50}, 'types': ['ice'], 'weight': 1750, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 80, 'gender_rate': -1, 'capture_rate': 3, 'color': 'blue', 'shape': 'humanoid', 'habitat': 'cave', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'レジアイス', 'roomaji': 'Regice', 'ko': '레지아이스', 'zh-Hant': '雷吉艾斯', 'fr': 'Regice', 'de': 'Regice', 'es': 'Regice', 'it': 'Regice', 'en': 'Regice', 'ja': 'レジアイス', 'zh-Hans': '雷吉艾斯'}, 'genera': {'ja-Hrkt': 'ひょうざんポケモン', 'ko': '빙산포켓몬', 'zh-Hant': '冰山寶可夢', 'fr': 'Pokémon Iceberg', 'de': 'Eisberg', 'es': 'Pokémon Iceberg', 'it': 'Pokémon Iceberg', 'en': 'Iceberg Pokémon', 'ja': 'ひょうざんポケモン', 'zh-Hans': '冰山宝可梦'}}
	public class SpecieRegice : PokemonSpecie
	{
#nullable enable
		private static SpecieRegice? _instance = null;
#nullable restore
        public static SpecieRegice Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRegice();
                }
                return _instance;
            }
        }

		public SpecieRegice() : base(
			"Regice",
			80, // HPs
			50, 100, // Attack & Defense
			100, 200, // Special Attack & Defense
			50			
		) {}
	}


	//Regice Pokemon Class
	public class Regice : Pokemon
	{

		public Regice(string nickname, int level)
		: base(
				378,
				SpecieRegice.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Regice() : base(
			378,
			SpecieRegice.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
	}
}