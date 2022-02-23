using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Beartic Specie to store common natural stats of every {'abilities': ['snow-cloak', 'slush-rush', 'swift-swim'], 'base_experience': 177, 'height': 26, 'id': 614, 'moves': ['ice-punch', 'swords-dance', 'cut', 'thrash', 'growl', 'roar', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'low-kick', 'strength', 'dig', 'toxic', 'double-team', 'bide', 'fury-swipes', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'flail', 'powder-snow', 'protect', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'rock-smash', 'hail', 'facade', 'focus-punch', 'taunt', 'superpower', 'brick-break', 'secret-power', 'dive', 'rock-tomb', 'sheer-cold', 'aerial-ace', 'bulk-up', 'covet', 'water-pulse', 'brine', 'fling', 'focus-blast', 'giga-impact', 'shadow-claw', 'stone-edge', 'grass-knot', 'aqua-jet', 'hone-claws', 'round', 'echoed-voice', 'bulldoze', 'frost-breath', 'icicle-crash', 'play-nice', 'confide', 'power-up-punch'], 'name': 'beartic', 'stats': {'hp': 95, 'attack': 130, 'defense': 80, 'special-attack': 70, 'special-defense': 80, 'speed': 50}, 'types': ['ice'], 'weight': 2600, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'white', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ツンベアー', 'ko': '툰베어', 'zh-Hant': '凍原熊', 'fr': 'Polagriffe', 'de': 'Siberio', 'es': 'Beartic', 'it': 'Beartic', 'en': 'Beartic', 'ja': 'ツンベアー', 'zh-Hans': '冻原熊'}, 'genera': {'ja-Hrkt': 'とうけつポケモン', 'ko': '동결포켓몬', 'zh-Hant': '凍結寶可夢', 'fr': 'Pokémon Congelé', 'de': 'Packeis', 'es': 'Pokémon Glaciación', 'it': 'Pokémon Glaciale', 'en': 'Freezing Pokémon', 'ja': 'とうけつポケモン', 'zh-Hans': '冻结宝可梦'}}
	public class SpecieBeartic : PokemonSpecie
	{
#nullable enable
		private static SpecieBeartic? _instance = null;
#nullable restore
        public static SpecieBeartic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBeartic();
                }
                return _instance;
            }
        }

		public SpecieBeartic() : base(
			"Beartic",
			95, // HPs
			130, 80, // Attack & Defense
			70, 80, // Special Attack & Defense
			50			
		) {}
	}


	//Beartic Pokemon Class
	public class Beartic : Pokemon
	{

		public Beartic(string nickname, int level) : base(
			614,
			SpecieBeartic.Instance, // Pokemon Specie
			nickname, level,
			Ice.Instance			
		) {}

		public Beartic() : base(
			614,
			SpecieBeartic.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
	}
}