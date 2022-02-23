using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cubone Specie to store common natural stats of every {'abilities': ['rock-head', 'lightning-rod', 'battle-armor'], 'base_experience': 64, 'height': 4, 'id': 104, 'moves': ['mega-punch', 'fire-punch', 'thunder-punch', 'swords-dance', 'double-kick', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'thrash', 'double-edge', 'tail-whip', 'leer', 'growl', 'flamethrower', 'water-gun', 'ice-beam', 'blizzard', 'bubble-beam', 'submission', 'low-kick', 'counter', 'seismic-toss', 'strength', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'focus-energy', 'bide', 'bone-club', 'fire-blast', 'skull-bash', 'bonemerang', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'protect', 'belly-drum', 'mud-slap', 'perish-song', 'icy-wind', 'detect', 'bone-rush', 'sandstorm', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'sunny-day', 'ancient-power', 'rock-smash', 'uproar', 'facade', 'focus-punch', 'brick-break', 'knock-off', 'endeavor', 'secret-power', 'rock-tomb', 'aerial-ace', 'iron-defense', 'natural-gift', 'fling', 'earth-power', 'rock-climb', 'iron-head', 'captivate', 'stealth-rock', 'smack-down', 'round', 'echoed-voice', 'chip-away', 'incinerate', 'retaliate', 'bulldoze', 'confide', 'power-up-punch', 'brutal-swing', 'stomping-tantrum'], 'name': 'cubone', 'stats': {'hp': 50, 'attack': 50, 'defense': 95, 'special-attack': 40, 'special-defense': 50, 'speed': 35}, 'types': ['ground'], 'weight': 65, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'brown', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'カラカラ', 'roomaji': 'Karakara', 'ko': '탕구리', 'zh-Hant': '卡拉卡拉', 'fr': 'Osselait', 'de': 'Tragosso', 'es': 'Cubone', 'it': 'Cubone', 'en': 'Cubone', 'ja': 'カラカラ', 'zh-Hans': '卡拉卡拉'}, 'genera': {'ja-Hrkt': 'こどくポケモン', 'ko': '고독포켓몬', 'zh-Hant': '孤獨寶可夢', 'fr': 'Pokémon Solitaire', 'de': 'Einsam', 'es': 'Pokémon Solitario', 'it': 'Pokémon Solitario', 'en': 'Lonely Pokémon', 'ja': 'こどくポケモン', 'zh-Hans': '孤独宝可梦'}}
	public class SpecieCubone : PokemonSpecie
	{
#nullable enable
		private static SpecieCubone? _instance = null;
#nullable restore
        public static SpecieCubone Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCubone();
                }
                return _instance;
            }
        }

		public SpecieCubone() : base(
			"Cubone",
			50, // HPs
			50, 95, // Attack & Defense
			40, 50, // Special Attack & Defense
			35			
		) {}
	}


	//Cubone Pokemon Class
	public class Cubone : Pokemon
	{

		public Cubone(string nickname, int level) : base(
			104,
			SpecieCubone.Instance, // Pokemon Specie
			nickname, level,
			Ground.Instance			
		) {}

		public Cubone() : base(
			104,
			SpecieCubone.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
	}
}