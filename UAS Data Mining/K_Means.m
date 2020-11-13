clear;
clc;

%data

[angka,txt,semua] = xlsread('Data_UAS.xlsx','A1:B49');

banyakData = size(angka,1);
banyakFungsi = size(angka,2);
data = angka;
Cluster = 3;
for i = 1:Cluster
    Anggota(i) = 0;
end
Centroid = [1 12 54];
iterasi = 0;
S = 0;
txt = string(txt);

while S == 0

    %Euclidean Distance
    for j = 1:Cluster
        for i = 1:length(data)
            C(i,j) = sqrt((Centroid(j)-data(i))^2);
        end
    end
    
    %Data C
    for i = 1:Cluster
        anggota(i).jml = 0;
    end
    
    for i = 1:length(data)
        anggotaTerpilih(i) = min(C(i,:));
        for j = 1:Cluster
            if anggotaTerpilih(i) >= C(i,j)
                anggota(j).isi(i) = data(i);
                anggota(j).isitxt(i) = txt(i);
                anggota(j).jml = anggota(j).jml + 1;
            end
        end
    end
    
    %Centroid Baru
    for i = 1:Cluster
        Centroid(i) = sum(anggota(i).isi)/anggota(i).jml;
    end
   
    iterasi = iterasi + 1;
    
    %Cek Berhenti
    if Anggota == [anggota.jml]
        for i = 1:Cluster
            x = Filter([anggota(i).isi anggota(i).isitxt],anggota(i).jml);
            y = Filtertxt(anggota(i).isitxt,anggota(i).jml);
            disp(['Anggota Cluster ' num2str(i) ' = ']);
            disp([x' y']);       
        end
        disp(['Iterasi = ' num2str(iterasi)]);
        S = 1;
    else
        Anggota = [anggota.jml];
    end
end

function H = Filter(bagian,c)
n = length(bagian);
B = bagian;

%cri isi
k = 1;
for i = 1:c
    H(i) = 0;
end

for i = 1:c
    for j = 1:n
        if (H(i) == 0)
            H(i) = B(k);
            k = k + 1;
        end
        
    end
end

end

function h = Filtertxt(A,c)
n = length(A);
b = fillmissing(A,'constant',"0");

%cri isi
k = 1;
for i = 1:c
    h(i) = "0";
end

for i = 1:c
    for j = 1:n
        if (h(i) == "0")
            h(i) = b(k);
            k = k + 1;
        end
        
    end
end

end