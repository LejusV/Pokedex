using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Eelektross Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 232, 'height': 21, 'id': 604, 'moves': ['fire-punch', 'thunder-punch', 'cut', 'bind', 'headbutt', 'thrash', 'roar', 'acid', 'flamethrower', 'hyper-beam', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'double-team', 'light-screen', 'flash', 'rest', 'rock-slide', 'super-fang', 'substitute', 'snore', 'protect', 'zap-cannon', 'outrage', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'crunch', 'rock-smash', 'facade', 'focus-punch', 'superpower', 'brick-break', 'knock-off', 'secret-power', 'crush-claw', 'rock-tomb', 'signal-beam', 'dragon-claw', 'bounce', 'shock-wave', 'u-turn', 'gastro-acid', 'magnet-rise', 'aqua-tail', 'dragon-pulse', 'drain-punch', 'giga-impact', 'flash-cannon', 'discharge', 'grass-knot', 'charge-beam', 'hone-claws', 'coil', 'round', 'acrobatics', 'volt-switch', 'dragon-tail', 'wild-charge', 'ion-deluge', 'confide', 'power-up-punch'], 'name': 'eelektross', 'stats': {'hp': 85, 'attack': 115, 'defense': 80, 'special-attack': 105, 'special-defense': 80, 'speed': 50}, 'types': ['electric'], 'weight': 805, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 30, 'color': 'blue', 'shape': 'fish', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'シビルドン', 'ko': '저리더프', 'zh-Hant': '麻麻鰻魚王', 'fr': 'Ohmassacre', 'de': 'Zapplarang', 'es': 'Eelektross', 'it': 'Eelektross', 'en': 'Eelektross', 'ja': 'シビルドン', 'zh-Hans': '麻麻鳗鱼王'}, 'genera': {'ja-Hrkt': 'でんきうおポケモン', 'ko': '전기물고기포켓몬', 'zh-Hant': '電魚寶可夢', 'fr': 'Pokémon Électrophore', 'de': 'Stromfisch', 'es': 'Pokémon Electropez', 'it': 'Pokémon Elettropesce', 'en': 'EleFish Pokémon', 'ja': 'でんきうおポケモン', 'zh-Hans': '电鱼宝可梦'}}
	public class SpecieEelektross : PokemonSpecie
	{
#nullable enable
		private static SpecieEelektross? _instance = null;
#nullable restore
        public static SpecieEelektross Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEelektross();
                }
                return _instance;
            }
        }

		public SpecieEelektross() : base(
			"Eelektross",
			85, // HPs
			115, 80, // Attack & Defense
			105, 80, // Special Attack & Defense
			50			
		) {}
	}


	//Eelektross Pokemon Class
	public class Eelektross : Pokemon
	{

		public Eelektross(string nickname, int level) : base(
			604,
			SpecieEelektross.Instance, // Pokemon Specie
			nickname, level,
			Electric.Instance			
		) {}

		public Eelektross() : base(
			604,
			SpecieEelektross.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}