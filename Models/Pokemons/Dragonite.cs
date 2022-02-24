using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dragonite Specie to store common natural stats of every {'abilities': ['inner-focus', 'multiscale'], 'base_experience': 270, 'height': 22, 'id': 149, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'razor-wind', 'cut', 'wing-attack', 'fly', 'bind', 'slam', 'headbutt', 'horn-drill', 'body-slam', 'wrap', 'take-down', 'double-edge', 'leer', 'roar', 'flamethrower', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'strength', 'dragon-rage', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'agility', 'rage', 'mimic', 'double-team', 'light-screen', 'reflect', 'bide', 'fire-blast', 'waterfall', 'swift', 'skull-bash', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'icy-wind', 'detect', 'outrage', 'sandstorm', 'endure', 'swagger', 'fury-cutter', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'dragon-breath', 'iron-tail', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'rock-smash', 'whirlpool', 'heat-wave', 'hail', 'facade', 'focus-punch', 'superpower', 'brick-break', 'secret-power', 'dive', 'air-cutter', 'rock-tomb', 'aerial-ace', 'dragon-claw', 'dragon-dance', 'shock-wave', 'water-pulse', 'roost', 'natural-gift', 'tailwind', 'fling', 'aqua-tail', 'dragon-pulse', 'dragon-rush', 'focus-blast', 'giga-impact', 'defog', 'draco-meteor', 'iron-head', 'stone-edge', 'captivate', 'ominous-wind', 'hone-claws', 'round', 'sky-drop', 'incinerate', 'bulldoze', 'dragon-tail', 'hurricane', 'confide', 'power-up-punch', 'brutal-swing'], 'name': 'dragonite', 'stats': {'hp': 91, 'attack': 134, 'defense': 95, 'special-attack': 100, 'special-defense': 100, 'speed': 80}, 'types': ['dragon', 'flying'], 'weight': 2100, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'brown', 'shape': 'upright', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['water1', 'dragon'], 'names': {'ja-Hrkt': 'カイリュー', 'roomaji': 'Kairyu', 'ko': '망나뇽', 'zh-Hant': '快龍', 'fr': 'Dracolosse', 'de': 'Dragoran', 'es': 'Dragonite', 'it': 'Dragonite', 'en': 'Dragonite', 'ja': 'カイリュー', 'zh-Hans': '快龙'}, 'genera': {'ja-Hrkt': 'ドラゴンポケモン', 'ko': '드래곤포켓몬', 'zh-Hant': '龍寶可夢', 'fr': 'Pokémon Dragon', 'de': 'Drache', 'es': 'Pokémon Dragón', 'it': 'Pokémon Drago', 'en': 'Dragon Pokémon', 'ja': 'ドラゴンポケモン', 'zh-Hans': '龙宝可梦'}}
	public class SpecieDragonite : PokemonSpecie
	{
#nullable enable
		private static SpecieDragonite? _instance = null;
#nullable restore
        public static SpecieDragonite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDragonite();
                }
                return _instance;
            }
        }

		public SpecieDragonite() : base(
			"Dragonite",
			91, // HPs
			134, 95, // Attack & Defense
			100, 100, // Special Attack & Defense
			80			
		) {}
	}


	//Dragonite Pokemon Class
	public class Dragonite : Pokemon
	{

		public Dragonite(string nickname, int level)
		: base(
				149,
				SpecieDragonite.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dragonite() : base(
			149,
			SpecieDragonite.Instance, // Pokemon Specie
			Dragon.Instance, Flying.Instance			
		) {}
	}
}