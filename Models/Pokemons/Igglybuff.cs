using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Igglybuff Specie to store common natural stats of every {'abilities': ['cute-charm', 'competitive', 'friend-guard'], 'base_experience': 42, 'height': 3, 'id': 174, 'moves': ['pound', 'mega-punch', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'sing', 'flamethrower', 'counter', 'seismic-toss', 'solar-beam', 'thunder-wave', 'dig', 'toxic', 'psychic', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'fire-blast', 'dream-eater', 'flash', 'rest', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'feint-attack', 'sweet-kiss', 'mud-slap', 'zap-cannon', 'perish-song', 'icy-wind', 'detect', 'endure', 'charm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'present', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'facade', 'helping-hand', 'role-play', 'wish', 'magic-coat', 'recycle', 'endeavor', 'secret-power', 'hyper-voice', 'fake-tears', 'bounce', 'covet', 'shock-wave', 'water-pulse', 'gravity', 'natural-gift', 'fling', 'copycat', 'punishment', 'last-resort', 'captivate', 'grass-knot', 'round', 'echoed-voice', 'heal-pulse', 'incinerate', 'work-up', 'wild-charge', 'misty-terrain', 'confide'], 'name': 'igglybuff', 'stats': {'hp': 90, 'attack': 30, 'defense': 15, 'special-attack': 40, 'special-defense': 20, 'speed': 15}, 'types': ['normal', 'fairy'], 'weight': 10, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 6, 'capture_rate': 170, 'color': 'pink', 'shape': 'humanoid', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ププリン', 'roomaji': 'Pupurin', 'ko': '푸푸린', 'zh-Hant': '寶寶丁', 'fr': 'Toudoudou', 'de': 'Fluffeluff', 'es': 'Igglybuff', 'it': 'Igglybuff', 'en': 'Igglybuff', 'ja': 'ププリン', 'zh-Hans': '宝宝丁'}, 'genera': {'ja-Hrkt': 'ふうせんポケモン', 'ko': '풍선포켓몬', 'zh-Hant': '氣球寶可夢', 'fr': 'Pokémon Bouboule', 'de': 'Ballon', 'es': 'Pokémon Globo', 'it': 'Pokémon Pallone', 'en': 'Balloon Pokémon', 'ja': 'ふうせんポケモン', 'zh-Hans': '气球宝可梦'}}
	public class SpecieIgglybuff : PokemonSpecie
	{
#nullable enable
		private static SpecieIgglybuff? _instance = null;
#nullable restore
        public static SpecieIgglybuff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieIgglybuff();
                }
                return _instance;
            }
        }

		public SpecieIgglybuff() : base(
			"Igglybuff",
			90, // HPs
			30, 15, // Attack & Defense
			40, 20, // Special Attack & Defense
			15			
		) {}
	}


	//Igglybuff Pokemon Class
	public class Igglybuff : Pokemon
	{

		public Igglybuff(string nickname, int level)
		: base(
				174,
				SpecieIgglybuff.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Igglybuff() : base(
			174,
			SpecieIgglybuff.Instance, // Pokemon Specie
			Normal.Instance, Fairy.Instance			
		) {}
	}
}