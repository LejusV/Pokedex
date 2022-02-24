using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rhydon Specie to store common natural stats of every {'abilities': ['lightning-rod', 'rock-head', 'reckless'], 'base_experience': 170, 'height': 19, 'id': 112, 'moves': ['mega-punch', 'pay-day', 'fire-punch', 'ice-punch', 'thunder-punch', 'swords-dance', 'cut', 'stomp', 'mega-kick', 'headbutt', 'horn-attack', 'fury-attack', 'horn-drill', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'leer', 'roar', 'flamethrower', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'thunderbolt', 'thunder', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'bide', 'fire-blast', 'skull-bash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'spite', 'protect', 'scary-face', 'mud-slap', 'zap-cannon', 'icy-wind', 'outrage', 'sandstorm', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'megahorn', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'ancient-power', 'rock-smash', 'whirlpool', 'uproar', 'facade', 'focus-punch', 'superpower', 'brick-break', 'endeavor', 'secret-power', 'rock-tomb', 'block', 'rock-blast', 'shock-wave', 'hammer-arm', 'natural-gift', 'payback', 'fling', 'rock-polish', 'poison-jab', 'aqua-tail', 'dragon-pulse', 'focus-blast', 'earth-power', 'giga-impact', 'avalanche', 'shadow-claw', 'rock-climb', 'stone-edge', 'captivate', 'stealth-rock', 'smack-down', 'round', 'chip-away', 'incinerate', 'bulldoze', 'dragon-tail', 'drill-run', 'confide', 'power-up-punch', 'smart-strike', 'brutal-swing'], 'name': 'rhydon', 'stats': {'hp': 105, 'attack': 130, 'defense': 120, 'special-attack': 45, 'special-defense': 45, 'speed': 40}, 'types': ['ground', 'rock'], 'weight': 1200, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'gray', 'shape': 'upright', 'habitat': 'rough-terrain', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['monster', 'ground'], 'names': {'ja-Hrkt': 'サイドン', 'roomaji': 'Sidon', 'ko': '코뿌리', 'zh-Hant': '鑽角犀獸', 'fr': 'Rhinoféros', 'de': 'Rizeros', 'es': 'Rhydon', 'it': 'Rhydon', 'en': 'Rhydon', 'ja': 'サイドン', 'zh-Hans': '钻角犀兽'}, 'genera': {'ja-Hrkt': 'ドリルポケモン', 'ko': '드릴포켓몬', 'zh-Hant': '鑽錐寶可夢', 'fr': 'Pokémon Perceur', 'de': 'Bohrer', 'es': 'Pokémon Taladro', 'it': 'Pokémon Trapano', 'en': 'Drill Pokémon', 'ja': 'ドリルポケモン', 'zh-Hans': '钻锥宝可梦'}}
	public class SpecieRhydon : PokemonSpecie
	{
#nullable enable
		private static SpecieRhydon? _instance = null;
#nullable restore
        public static SpecieRhydon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRhydon();
                }
                return _instance;
            }
        }

		public SpecieRhydon() : base(
			"Rhydon",
			105, // HPs
			130, 120, // Attack & Defense
			45, 45, // Special Attack & Defense
			40			
		) {}
	}


	//Rhydon Pokemon Class
	public class Rhydon : Pokemon
	{

		public Rhydon(string nickname, int level)
		: base(
				112,
				SpecieRhydon.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Rhydon(int level)
		: base(
				112,
				SpecieRhydon.Instance, // Pokemon Specie
				"Rhydon", level,
				Ground.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Rhydon() : base(
			112,
			SpecieRhydon.Instance, // Pokemon Specie
			Ground.Instance, Rock.Instance			
		) {}
	}
}