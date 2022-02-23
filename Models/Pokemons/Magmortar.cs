using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Magmortar Specie to store common natural stats of every {'abilities': ['flame-body', 'vital-spirit'], 'base_experience': 243, 'height': 16, 'id': 467, 'moves': ['fire-punch', 'thunder-punch', 'headbutt', 'leer', 'ember', 'flamethrower', 'hyper-beam', 'low-kick', 'strength', 'solar-beam', 'fire-spin', 'thunderbolt', 'earthquake', 'toxic', 'psychic', 'double-team', 'smokescreen', 'confuse-ray', 'smog', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'protect', 'feint-attack', 'mud-slap', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'sunny-day', 'rock-smash', 'heat-wave', 'torment', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'brick-break', 'secret-power', 'overheat', 'rock-tomb', 'covet', 'natural-gift', 'fling', 'focus-blast', 'giga-impact', 'rock-climb', 'lava-plume', 'captivate', 'flame-burst', 'flame-charge', 'low-sweep', 'round', 'clear-smog', 'incinerate', 'bulldoze', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'magmortar', 'stats': {'hp': 75, 'attack': 95, 'defense': 67, 'special-attack': 125, 'special-defense': 95, 'speed': 83}, 'types': ['fire'], 'weight': 680, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 2, 'capture_rate': 30, 'color': 'red', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ブーバーン', 'roomaji': 'Booburn', 'ko': '마그마번', 'zh-Hant': '鴨嘴炎獸', 'fr': 'Maganon', 'de': 'Magbrant', 'es': 'Magmortar', 'it': 'Magmortar', 'en': 'Magmortar', 'ja': 'ブーバーン', 'zh-Hans': '鸭嘴炎兽'}, 'genera': {'ja-Hrkt': 'ばくえんポケモン', 'ko': '폭염포켓몬', 'zh-Hant': '爆炎寶可夢', 'fr': 'Pokémon Explosion', 'de': 'Detonation', 'es': 'Pokémon Explosión', 'it': 'Pokémon Esplosivo', 'en': 'Blast Pokémon', 'ja': 'ばくえんポケモン', 'zh-Hans': '爆炎宝可梦'}}
	public class SpecieMagmortar : PokemonSpecie
	{
#nullable enable
		private static SpecieMagmortar? _instance = null;
#nullable restore
        public static SpecieMagmortar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagmortar();
                }
                return _instance;
            }
        }

		public SpecieMagmortar() : base(
			"Magmortar",
			75, // HPs
			95, 67, // Attack & Defense
			125, 95, // Special Attack & Defense
			83			
		) {}
	}


	//Magmortar Pokemon Class
	public class Magmortar : Pokemon
	{

		public Magmortar(string nickname, int level) : base(
			467,
			SpecieMagmortar.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance			
		) {}

		public Magmortar() : base(
			467,
			SpecieMagmortar.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}