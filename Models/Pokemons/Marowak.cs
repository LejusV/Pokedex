using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Marowak Specie to store common natural stats of every {'abilities': ['rock-head', 'lightning-rod', 'battle-armor'], 'base_experience': 149, 'height': 10, 'id': 105, 'moves': ['mega-punch', 'fire-punch', 'thunder-punch', 'swords-dance', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'thrash', 'double-edge', 'tail-whip', 'leer', 'growl', 'flamethrower', 'water-gun', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'low-kick', 'counter', 'seismic-toss', 'strength', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'focus-energy', 'bide', 'bone-club', 'fire-blast', 'skull-bash', 'bonemerang', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'icy-wind', 'detect', 'bone-rush', 'outrage', 'sandstorm', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'sunny-day', 'rock-smash', 'uproar', 'facade', 'focus-punch', 'brick-break', 'knock-off', 'endeavor', 'secret-power', 'rock-tomb', 'aerial-ace', 'iron-defense', 'natural-gift', 'fling', 'focus-blast', 'earth-power', 'giga-impact', 'rock-climb', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'smack-down', 'round', 'echoed-voice', 'incinerate', 'retaliate', 'bulldoze', 'confide', 'power-up-punch', 'brutal-swing', 'stomping-tantrum'], 'name': 'marowak', 'stats': {'hp': 60, 'attack': 80, 'defense': 110, 'special-attack': 50, 'special-defense': 80, 'speed': 45}, 'types': ['ground'], 'weight': 450, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'brown', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'ガラガラ', 'roomaji': 'Garagara', 'ko': '텅구리', 'zh-Hant': '嘎啦嘎啦', 'fr': 'Ossatueur', 'de': 'Knogga', 'es': 'Marowak', 'it': 'Marowak', 'en': 'Marowak', 'ja': 'ガラガラ', 'zh-Hans': '嘎啦嘎啦'}, 'genera': {'ja-Hrkt': 'ほねずきポケモン', 'ko': '뼈다귀포켓몬', 'zh-Hant': '愛骨寶可夢', 'fr': 'Pokémon Gard’Os', 'de': 'Knochenfan', 'es': 'Pokémon Apilahueso', 'it': 'Pokémon Guardaossi', 'en': 'Bone Keeper Pokémon', 'ja': 'ほねずきポケモン', 'zh-Hans': '爱骨宝可梦'}}
	public class SpecieMarowak : PokemonSpecie
	{
#nullable enable
		private static SpecieMarowak? _instance = null;
#nullable restore
        public static SpecieMarowak Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMarowak();
                }
                return _instance;
            }
        }

		public SpecieMarowak() : base(
			"Marowak",
			60, // HPs
			80, 110, // Attack & Defense
			50, 80, // Special Attack & Defense
			45			
		) {}
	}


	//Marowak Pokemon Class
	public class Marowak : Pokemon
	{

		public Marowak(string nickname, int level) : base(
			105,
			SpecieMarowak.Instance, // Pokemon Specie
			nickname, level,
			Ground.Instance			
		) {}

		public Marowak() : base(
			105,
			SpecieMarowak.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
	}
}