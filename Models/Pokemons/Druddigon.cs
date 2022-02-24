using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Druddigon Specie to store common natural stats of every {'abilities': ['rough-skin', 'sheer-force', 'mold-breaker'], 'base_experience': 170, 'height': 16, 'id': 621, 'moves': ['fire-punch', 'thunder-punch', 'scratch', 'cut', 'leer', 'bite', 'roar', 'flamethrower', 'surf', 'hyper-beam', 'strength', 'dragon-rage', 'earthquake', 'dig', 'toxic', 'double-team', 'glare', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'scary-face', 'feint-attack', 'sludge-bomb', 'outrage', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'iron-tail', 'metal-claw', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'rock-smash', 'heat-wave', 'torment', 'facade', 'taunt', 'superpower', 'revenge', 'snatch', 'secret-power', 'crush-claw', 'rock-tomb', 'aerial-ace', 'dragon-claw', 'poison-tail', 'shock-wave', 'payback', 'fling', 'sucker-punch', 'dark-pulse', 'night-slash', 'aqua-tail', 'dragon-pulse', 'focus-blast', 'giga-impact', 'shadow-claw', 'thunder-fang', 'fire-fang', 'flash-cannon', 'rock-climb', 'draco-meteor', 'gunk-shot', 'iron-head', 'stealth-rock', 'charge-beam', 'hone-claws', 'smack-down', 'round', 'chip-away', 'incinerate', 'retaliate', 'bulldoze', 'dragon-tail', 'snarl', 'confide', 'power-up-punch'], 'name': 'druddigon', 'stats': {'hp': 77, 'attack': 120, 'defense': 90, 'special-attack': 60, 'special-defense': 90, 'speed': 48}, 'types': ['dragon'], 'weight': 1390, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 4, 'capture_rate': 45, 'color': 'red', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'クリムガン', 'ko': '크리만', 'zh-Hant': '赤面龍', 'fr': 'Drakkarmin', 'de': 'Shardrago', 'es': 'Druddigon', 'it': 'Druddigon', 'en': 'Druddigon', 'ja': 'クリムガン', 'zh-Hans': '赤面龙'}, 'genera': {'ja-Hrkt': 'ほらあなポケモン', 'ko': '동굴포켓몬', 'zh-Hant': '洞穴寶可夢', 'fr': 'Pokémon Caverne', 'de': 'Höhle', 'es': 'Pokémon Cueva', 'it': 'Pokémon Grotta', 'en': 'Cave Pokémon', 'ja': 'ほらあなポケモン', 'zh-Hans': '洞穴宝可梦'}}
	public class SpecieDruddigon : PokemonSpecie
	{
#nullable enable
		private static SpecieDruddigon? _instance = null;
#nullable restore
        public static SpecieDruddigon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDruddigon();
                }
                return _instance;
            }
        }

		public SpecieDruddigon() : base(
			"Druddigon",
			77, // HPs
			120, 90, // Attack & Defense
			60, 90, // Special Attack & Defense
			48			
		) {}
	}


	//Druddigon Pokemon Class
	public class Druddigon : Pokemon
	{

		public Druddigon(string nickname, int level)
		: base(
				621,
				SpecieDruddigon.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Druddigon() : base(
			621,
			SpecieDruddigon.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
	}
}