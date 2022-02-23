using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Torchic Specie to store common natural stats of every {'abilities': ['blaze', 'speed-boost'], 'base_experience': 62, 'height': 4, 'id': 255, 'moves': ['mega-punch', 'scratch', 'swords-dance', 'cut', 'mega-kick', 'sand-attack', 'headbutt', 'body-slam', 'double-edge', 'growl', 'ember', 'flamethrower', 'peck', 'low-kick', 'counter', 'seismic-toss', 'strength', 'fire-spin', 'dig', 'toxic', 'agility', 'quick-attack', 'mimic', 'double-team', 'focus-energy', 'mirror-move', 'fire-blast', 'swift', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'curse', 'reversal', 'protect', 'mud-slap', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'baton-pass', 'hidden-power', 'sunny-day', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'smelling-salts', 'helping-hand', 'secret-power', 'feather-dance', 'crush-claw', 'overheat', 'rock-tomb', 'aerial-ace', 'bounce', 'natural-gift', 'feint', 'last-resort', 'night-slash', 'shadow-claw', 'captivate', 'hone-claws', 'flame-burst', 'flame-charge', 'round', 'echoed-voice', 'incinerate', 'fire-pledge', 'work-up', 'confide'], 'name': 'torchic', 'stats': {'hp': 45, 'attack': 60, 'defense': 40, 'special-attack': 70, 'special-defense': 50, 'speed': 45}, 'types': ['fire'], 'weight': 25, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'red', 'shape': 'legs', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'アチャモ', 'roomaji': 'Achamo', 'ko': '아차모', 'zh-Hant': '火稚雞', 'fr': 'Poussifeu', 'de': 'Flemmli', 'es': 'Torchic', 'it': 'Torchic', 'en': 'Torchic', 'ja': 'アチャモ', 'zh-Hans': '火稚鸡'}, 'genera': {'ja-Hrkt': 'ひよこポケモン', 'ko': '풋내기포켓몬', 'zh-Hant': '雛雞寶可夢', 'fr': 'Pokémon Poussin', 'de': 'Küken', 'es': 'Pokémon Polluelo', 'it': 'Pokémon Pulcino', 'en': 'Chick Pokémon', 'ja': 'ひよこポケモン', 'zh-Hans': '雏鸡宝可梦'}}
	public class SpecieTorchic : PokemonSpecie
	{
#nullable enable
		private static SpecieTorchic? _instance = null;
#nullable restore
        public static SpecieTorchic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTorchic();
                }
                return _instance;
            }
        }

		public SpecieTorchic() : base(
			"Torchic",
			45, // HPs
			60, 40, // Attack & Defense
			70, 50, // Special Attack & Defense
			45			
		) {}
	}


	//Torchic Pokemon Class
	public class Torchic : Pokemon
	{

		public Torchic(string nickname, int level) : base(
			255,
			SpecieTorchic.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance			
		) {}

		public Torchic() : base(
			255,
			SpecieTorchic.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}