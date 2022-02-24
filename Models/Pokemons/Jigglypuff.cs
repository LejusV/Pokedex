using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Jigglypuff Specie to store common natural stats of every {'abilities': ['cute-charm', 'competitive', 'friend-guard'], 'base_experience': 95, 'height': 5, 'id': 39, 'moves': ['pound', 'double-slap', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'sing', 'disable', 'flamethrower', 'water-gun', 'ice-beam', 'blizzard', 'bubble-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'psychic', 'rage', 'teleport', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'bide', 'fire-blast', 'skull-bash', 'dream-eater', 'flash', 'psywave', 'rest', 'tri-attack', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'icy-wind', 'detect', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'pain-split', 'dynamic-punch', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'stockpile', 'spit-up', 'swallow', 'facade', 'focus-punch', 'helping-hand', 'role-play', 'magic-coat', 'recycle', 'brick-break', 'knock-off', 'endeavor', 'snatch', 'secret-power', 'hyper-voice', 'bounce', 'covet', 'shock-wave', 'water-pulse', 'gravity', 'wake-up-slap', 'gyro-ball', 'natural-gift', 'fling', 'last-resort', 'drain-punch', 'captivate', 'stealth-rock', 'grass-knot', 'charge-beam', 'round', 'echoed-voice', 'incinerate', 'retaliate', 'work-up', 'wild-charge', 'disarming-voice', 'play-nice', 'confide', 'dazzling-gleam', 'power-up-punch'], 'name': 'jigglypuff', 'stats': {'hp': 115, 'attack': 45, 'defense': 20, 'special-attack': 45, 'special-defense': 25, 'speed': 20}, 'types': ['normal', 'fairy'], 'weight': 55, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 6, 'capture_rate': 170, 'color': 'pink', 'shape': 'humanoid', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'fast', 'egg_groups': ['fairy'], 'names': {'ja-Hrkt': 'プリン', 'roomaji': 'Purin', 'ko': '푸린', 'zh-Hant': '胖丁', 'fr': 'Rondoudou', 'de': 'Pummeluff', 'es': 'Jigglypuff', 'it': 'Jigglypuff', 'en': 'Jigglypuff', 'ja': 'プリン', 'zh-Hans': '胖丁'}, 'genera': {'ja-Hrkt': 'ふうせんポケモン', 'ko': '풍선포켓몬', 'zh-Hant': '氣球寶可夢', 'fr': 'Pokémon Bouboule', 'de': 'Ballon', 'es': 'Pokémon Globo', 'it': 'Pokémon Pallone', 'en': 'Balloon Pokémon', 'ja': 'ふうせんポケモン', 'zh-Hans': '气球宝可梦'}}
	public class SpecieJigglypuff : PokemonSpecie
	{
#nullable enable
		private static SpecieJigglypuff? _instance = null;
#nullable restore
        public static SpecieJigglypuff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieJigglypuff();
                }
                return _instance;
            }
        }

		public SpecieJigglypuff() : base(
			"Jigglypuff",
			115, // HPs
			45, 20, // Attack & Defense
			45, 25, // Special Attack & Defense
			20			
		) {}
	}


	//Jigglypuff Pokemon Class
	public class Jigglypuff : Pokemon
	{

		public Jigglypuff(string nickname, int level)
		: base(
				39,
				SpecieJigglypuff.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Jigglypuff(int level)
		: base(
				39,
				SpecieJigglypuff.Instance, // Pokemon Specie
				"Jigglypuff", level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Jigglypuff() : base(
			39,
			SpecieJigglypuff.Instance, // Pokemon Specie
			Normal.Instance, Fairy.Instance			
		) {}
	}
}