using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Buizel Specie to store common natural stats of every {'abilities': ['swift-swim', 'water-veil'], 'base_experience': 66, 'height': 7, 'id': 418, 'moves': ['double-slap', 'ice-punch', 'razor-wind', 'headbutt', 'growl', 'sonic-boom', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'strength', 'dig', 'toxic', 'agility', 'quick-attack', 'double-team', 'waterfall', 'swift', 'fury-swipes', 'rest', 'slash', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'baton-pass', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'rock-smash', 'whirlpool', 'hail', 'facade', 'focus-punch', 'helping-hand', 'brick-break', 'secret-power', 'dive', 'odor-sleuth', 'rock-tomb', 'bulk-up', 'water-sport', 'water-pulse', 'brine', 'natural-gift', 'me-first', 'aqua-ring', 'aqua-tail', 'switcheroo', 'captivate', 'aqua-jet', 'double-hit', 'soak', 'round', 'echoed-voice', 'scald', 'tail-slap', 'confide', 'power-up-punch'], 'name': 'buizel', 'stats': {'hp': 55, 'attack': 65, 'defense': 35, 'special-attack': 60, 'special-defense': 30, 'speed': 85}, 'types': ['water'], 'weight': 295, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'ブイゼル', 'roomaji': 'Buoysel', 'ko': '브이젤', 'zh-Hant': '泳圈鼬', 'fr': 'Mustébouée', 'de': 'Bamelin', 'es': 'Buizel', 'it': 'Buizel', 'en': 'Buizel', 'ja': 'ブイゼル', 'zh-Hans': '泳圈鼬'}, 'genera': {'ja-Hrkt': 'うみイタチポケモン', 'ko': '바다족제비포켓몬', 'zh-Hant': '海鼬寶可夢', 'fr': 'Pokémon Aquabelette', 'de': 'Meereswiesel', 'es': 'Pokémon Nutria Mar.', 'it': 'Pokémon Maridonnola', 'en': 'Sea Weasel Pokémon', 'ja': 'うみイタチポケモン', 'zh-Hans': '海鼬宝可梦'}}
	public class SpecieBuizel : PokemonSpecie
	{
#nullable enable
		private static SpecieBuizel? _instance = null;
#nullable restore
        public static SpecieBuizel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBuizel();
                }
                return _instance;
            }
        }

		public SpecieBuizel() : base(
			"Buizel",
			55, // HPs
			65, 35, // Attack & Defense
			60, 30, // Special Attack & Defense
			85			
		) {}
	}


	//Buizel Pokemon Class
	public class Buizel : Pokemon
	{

		public Buizel(string nickname, int level) : base(
			418,
			SpecieBuizel.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Buizel() : base(
			418,
			SpecieBuizel.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}