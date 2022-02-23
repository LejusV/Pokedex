using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Diglett Specie to store common natural stats of every {'abilities': ['sand-veil', 'arena-trap', 'sand-force'], 'base_experience': 53, 'height': 2, 'id': 50, 'moves': ['scratch', 'cut', 'sand-attack', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'growl', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'bide', 'fury-swipes', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'snore', 'curse', 'reversal', 'protect', 'feint-attack', 'sludge-bomb', 'mud-slap', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'magnitude', 'pursuit', 'hidden-power', 'sunny-day', 'ancient-power', 'rock-smash', 'beat-up', 'uproar', 'memento', 'facade', 'secret-power', 'astonish', 'rock-tomb', 'aerial-ace', 'natural-gift', 'sucker-punch', 'earth-power', 'shadow-claw', 'mud-bomb', 'captivate', 'stealth-rock', 'hone-claws', 'round', 'echoed-voice', 'final-gambit', 'bulldoze', 'confide'], 'name': 'diglett', 'stats': {'hp': 10, 'attack': 55, 'defense': 25, 'special-attack': 35, 'special-defense': 45, 'speed': 95}, 'types': ['ground'], 'weight': 8, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'blob', 'habitat': 'cave', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ディグダ', 'roomaji': 'Digda', 'ko': '디그다', 'zh-Hant': '地鼠', 'fr': 'Taupiqueur', 'de': 'Digda', 'es': 'Diglett', 'it': 'Diglett', 'en': 'Diglett', 'ja': 'ディグダ', 'zh-Hans': '地鼠'}, 'genera': {'ja-Hrkt': 'もぐらポケモン', 'ko': '두더지포켓몬', 'zh-Hant': '鼴鼠寶可夢', 'fr': 'Pokémon Taupe', 'de': 'Maulwurf', 'es': 'Pokémon Topo', 'it': 'Pokémon Talpa', 'en': 'Mole Pokémon', 'ja': 'もぐらポケモン', 'zh-Hans': '鼹鼠宝可梦'}}
	public class SpecieDiglett : PokemonSpecie
	{
#nullable enable
		private static SpecieDiglett? _instance = null;
#nullable restore
        public static SpecieDiglett Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDiglett();
                }
                return _instance;
            }
        }

		public SpecieDiglett() : base(
			"Diglett",
			10, // HPs
			55, 25, // Attack & Defense
			35, 45, // Special Attack & Defense
			95			
		) {}
	}


	//Diglett Pokemon Class
	public class Diglett : Pokemon
	{

		public Diglett(string nickname, int level) : base(
			50,
			SpecieDiglett.Instance, // Pokemon Specie
			nickname, level,
			Ground.Instance			
		) {}

		public Diglett() : base(
			50,
			SpecieDiglett.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
	}
}