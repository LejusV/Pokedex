using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Magcargo Specie to store common natural stats of every {'abilities': ['magma-armor', 'flame-body', 'weak-armor'], 'base_experience': 151, 'height': 8, 'id': 219, 'moves': ['body-slam', 'double-edge', 'ember', 'flamethrower', 'hyper-beam', 'strength', 'solar-beam', 'rock-throw', 'earthquake', 'toxic', 'mimic', 'double-team', 'recover', 'harden', 'defense-curl', 'light-screen', 'reflect', 'self-destruct', 'smog', 'fire-blast', 'amnesia', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'sunny-day', 'ancient-power', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'nature-power', 'yawn', 'secret-power', 'overheat', 'rock-tomb', 'iron-defense', 'gyro-ball', 'natural-gift', 'rock-polish', 'earth-power', 'giga-impact', 'lava-plume', 'stone-edge', 'captivate', 'stealth-rock', 'smack-down', 'flame-burst', 'flame-charge', 'after-you', 'round', 'clear-smog', 'shell-smash', 'incinerate', 'bulldoze', 'confide', 'infestation'], 'name': 'magcargo', 'stats': {'hp': 60, 'attack': 50, 'defense': 120, 'special-attack': 90, 'special-defense': 80, 'speed': 30}, 'types': ['fire', 'rock'], 'weight': 550, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'red', 'shape': 'squiggle', 'habitat': 'mountain', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'マグカルゴ', 'roomaji': 'Magcargot', 'ko': '마그카르고', 'zh-Hant': '熔岩蝸牛', 'fr': 'Volcaropod', 'de': 'Magcargo', 'es': 'Magcargo', 'it': 'Magcargo', 'en': 'Magcargo', 'ja': 'マグカルゴ', 'zh-Hans': '熔岩蜗牛'}, 'genera': {'ja-Hrkt': 'ようがんポケモン', 'ko': '용암포켓몬', 'zh-Hant': '熔岩寶可夢', 'fr': 'Pokémon Lave', 'de': 'Lava', 'es': 'Pokémon Lava', 'it': 'Pokémon Lava', 'en': 'Lava Pokémon', 'ja': 'ようがんポケモン', 'zh-Hans': '熔岩宝可梦'}}
	public class SpecieMagcargo : PokemonSpecie
	{
#nullable enable
		private static SpecieMagcargo? _instance = null;
#nullable restore
        public static SpecieMagcargo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagcargo();
                }
                return _instance;
            }
        }

		public SpecieMagcargo() : base(
			"Magcargo",
			60, // HPs
			50, 120, // Attack & Defense
			90, 80, // Special Attack & Defense
			30			
		) {}
	}


	//Magcargo Pokemon Class
	public class Magcargo : Pokemon
	{

		public Magcargo(string nickname, int level) : base(
			219,
			SpecieMagcargo.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance, Rock.Instance			
		) {}

		public Magcargo() : base(
			219,
			SpecieMagcargo.Instance, // Pokemon Specie
			Fire.Instance, Rock.Instance			
		) {}
	}
}